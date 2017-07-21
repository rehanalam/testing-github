
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Calc.PCL.Controllers;
using Calc.PCL.Exceptions;
using Calc.PCL.Models;

namespace Calc.PCL.Utilities
{
    public class AuthManager
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AuthManager instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AuthManager Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AuthManager();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        public OAuthToken Authorize(string authorizationCode, Dictionary<string, object> additionalParameters = null)
        {
            string authorizationHeader = BuildBasicAuthheader(Configuration.OAuthClientId,
                Configuration.OAuthClientSecret);
            OAuthToken token = OAuthAuthorizationController.Instance.CreateRequestToken(authorizationHeader, authorizationCode,Configuration.OAuthRedirectUri, additionalParameters);
            UpdateAccessToken(token);
            return token;
        }


        public string BuildBasicAuthheader(string username, string password)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(username + ':' + password);
            return "Basic " + Convert.ToBase64String(plainTextBytes);
        }

        public OAuthToken RefreshToken(List<OAuthScopeEnum> scopes = null,Dictionary<string, object> additionalParameters = null)
        {
            string authorizationHeader = BuildBasicAuthheader(Configuration.OAuthClientId,
                Configuration.OAuthClientSecret);
            OAuthToken token = OAuthAuthorizationController.Instance.CreateRefreshToken(authorizationHeader,Configuration.OAuthToken.RefreshToken,(scopes != null) ? String.Join(" ", scopes.Select(OAuthScopeEnumHelper.ToValue).ToArray()) : null,additionalParameters);
            UpdateAccessToken(token);
            return token;
        }

        public string BuildAuthorizationUrl(string state,List<OAuthScopeEnum> scopes = null,Dictionary<string,object> additionalParameters = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/authorize");

            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>
            {
                { "response_type", "code" },
                { "client_id" , Configuration.OAuthClientId},
                { "redirect_uri" , Configuration.OAuthRedirectUri},
                { "state" , state}
            });
            if(scopes!=null)
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder,new Dictionary<string,object>()
            {
                { "scope", String.Join(" ",scopes.ToArray().Select(OAuthScopeEnumHelper.ToValue))}
            });
            if(additionalParameters!=null)
                APIHelper.AppendUrlWithQueryParameters(_queryBuilder,additionalParameters);

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            return _queryUrl;
        }
        public void UpdateAccessToken(OAuthToken token)
        {
            if (token.ExpiresIn != null && token.ExpiresIn!=0)
                token.Expiry = token.ExpiresIn.Value + (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

            Configuration.OAuthToken = token;
            if(Configuration.OAuthTokenUpdateCallback!=null)
                Configuration.OAuthTokenUpdateCallback.Invoke(token);
        }

        public void CheckAuthorization()
        {
            if (Configuration.OAuthToken == null)
                throw new APIException("Access token not set. To get a new token use the authorize method",null);
            if (Configuration.OAuthToken.Expiry <=
                (long) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds)
                Configuration.OAuthToken = RefreshToken();
        } 
    }
}