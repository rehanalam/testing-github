using Calc.PCL.Models;
namespace Calc.PCL
{
    public partial class Configuration
    {
        public delegate void OAuthTokenUpdateDelegate(OAuthToken token);

        public static OAuthToken OAuthToken;

        public static OAuthTokenUpdateDelegate OAuthTokenUpdateCallback;

        //The base Uri for API calls
        public static string BaseUri = "http://examples.apimatic.io/apps/calculator";

        //a
        //TODO: Replace the A with an appropriate value
        public static string A = "a";

        //OAuth 2 Client ID
        //TODO: Replace the OAuthClientId with an appropriate value
        public static string OAuthClientId = "TODO: Replace";

        //OAuth 2 Client Secret
        //TODO: Replace the OAuthClientSecret with an appropriate value
        public static string OAuthClientSecret = "TODO: Replace";

        //OAuth 2 Redirection endpoint or Callback Uri
        //TODO: Replace the OAuthRedirectUri with an appropriate value
        public static string OAuthRedirectUri = "TODO: Replace";

    }
}