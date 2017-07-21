# Getting started

TODO: Add a description

## How to Build

The generated SDK requires AngularJS framework to work. If you do not already have angular downloaded, please go ahead and do it from [here](https://angularjs.org/).
If any of your models have `Date` or `Datetime` type fields or your endpoints have `Date`/`Datetime` type response, you will need to download and link [angular-moment](https://cdnjs.cloudflare.com/ajax/libs/angular-moment/1.0.1/angular-moment.min.js) and [moment.js](https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.17.1/moment.min.js) with your project.

## How to Use

The following section describes how to use the generated SDK in an existing/new project.

### 1. Configure Angular and Generated SDK
Perform the following steps to configure angular and the SDK:
+ Make a `scripts` folder inside the root folder of the project. If you already have a `scripts` folder, skip to the next step.
+ Move the `angular.min.js` file inside the scripts folder. 
+ Move the `DudeIntelligenceApiLib` folder inside the scripts folder.
+ If any of the Custom Types in your API have `Date`/`Datetime` type fields or any endpoint has `Date`/`Datetime` response, you will need to download angular-moment and moment.js. Move these 2 files into the `scripts` folder as well.

![folder-structure-image](https://apidocs.io/illustration/angularjs?step=folderStructure&workspaceFolder=Dude%20Intelligence%20Api-Angular&projectName=DudeIntelligenceApiLib)

### 2. Open Project Folder
Open an IDE/Text Editor for JavaScript like Sublime Text. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.  
Click on `File` and select `Open Folder`

Select the folder of your SDK and click on `Select Folder` to open it up in Sublime Text. The folder will become visible in the bar on the left.

![open-folder-image](https://apidocs.io/illustration/angularjs?step=openFolder&workspaceFolder=Dude%20Intelligence%20Api-Angular)

### 3. Create an Angular Application
Since Angular JS is used for client-side web development, in order to use the generated library, you will have to develop an application first.
If you already have an angular application, [skip to Step 6](#6-include-sdk-references-in-html-file). Otherwise, follow these steps to create one:

+ In the IDE, click on `File` and choose `New File` to create a new file.
+ Add the following starting code in the file:
```js
var app = angular.module('myApp', []);
app.controller('testController', function($scope) 
{

});
```
+ Save it with the name `app.js` in the `scripts` folder.


### 4. Create HTML File
Skip to the next step if you are working with an existing project and already have an html file. Otherwise follow the steps to create one:
+ Inside the IDE, right click on the project folder name and select the `New File` option to create a new test file.
+ Save it with an appropriate name such as `index.html` in the root of your project folder.
`index.html` should look like this:
```html
<!DOCTYPE html>
<html>
<head>
	<title>Angular Project</title>
	<script></script>
</head>

<body>
</body>

</html>
```

![initial-html-code-image](https://apidocs.io/illustration/angularjs?step=initialCode&workspaceFolder=Dude%20Intelligence%20Api-Angular)

### 5. Including links to Angular in HTML file
Your HTML file needs to have a link to `angular.min.js` file to use Angular-JS. Add the link using `script` tags inside the `head` section of `index.html` like:
```html
<script src="scripts/angular.min.js" ></script>
```
If any of the Custom Types that you have defined have `Date`/`Datetime` type fields or any endpoint has `Date`/`Datetime` response, you will also need to link to angular-moment and moment.js like:
```html
<script src="scripts/angular.min.js" ></script>
<script src="scripts/moment.min.js" ></script>
<script src="scripts/angular-moment.min.js" ></script>
```

### 6. Include SDK references in HTML file
Import the reference to the generated SDK files inside your html file like:
```html
<head>
    ...
    <!-- Helper files -->
    <script src="scripts/DudeIntelligenceApiLib/Module.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Configuration.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/ModelFactory.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/ObjectMapper.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/APIHelper.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Http/Client/HttpContext.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Http/Client/RequestClient.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Http/Request/HttpRequest.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Http/Response/HttpResponse.js"></script>

    <!-- API Controllers -->
    <script src="scripts/DudeIntelligenceApiLib/Controllers/BaseController.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Controllers/SystemInformation.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Controllers/Heartbeat.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Controllers/ExecutiveSummaries.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Controllers/ScheduledReports.js"></script>


    <!-- Models -->
    <script src="scripts/DudeIntelligenceApiLib/Models/BaseModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/SystemInformationModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/HeartbeatModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/SystemLinksModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/BaseCollectionResponseModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/BaseUserObjectModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/BaseClientObjectModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/ExecutiveSummaryDataModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/ScheduledReportDataModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/GetSummaryCollectionResponseModel.js"></script>
    <script src="scripts/DudeIntelligenceApiLib/Models/GetScheduledReportsCollectionResponseModel.js"></script>

    ...
</head>
```
> The `Module.js` file should be imported before the other files. After `Module.js`, `Configuration.js` should be imported.
> The `ModelFactory.js` file is needed by `ObjectMapper.js` file. The `ObjectMapper` in turn, is needed by `BaseController.js`.

### 7. Including link to `app.js` in HTML file
Link your `app.js` file to your `index.html` file like:
```html
<head>
	...
	<script src="scripts/app.js"></script>
</head>
```
> The link to app.js needs to be included at the very end of the head tag, after the SDK references have been added

### 8. Initializing the Angular App
You need to initialize your app and the controller associated with your view inside your `index.html` file. Do so like:
+ Add ng-app directive to initialize your app inside the `body` tag.
```html
<body ng-app="myApp">
```
+ Add ng-controller directive to initialize your controller and bind it with your view (`index.html` file).
```html
...
<body ng-app="myApp">
	<div ng-controller="testController">
		...
	</div>
	...
</body>
...
```

### 9. Consuming the SDK 
In order to use the generated SDK's modules, controllers and factories, the project needs to be added as a dependency in your angular app's module. This will be done inside the `app.js` file.
Add the dependency like this:

```js
var app = angular.module('myApp', ['DudeIntelligenceApiLib']);
```
At this point, the SDK has been successfully included in your project. Further steps include using a service/factory from the generated SDK. To see working example of this, please head on [over here](#list-of-controllers) and choose any class to see its functions and example usage.  

### 10. Running The App
To run the app, simply open up the `index.html` file in a browser.

![app-running](https://apidocs.io/illustration/angularjs?step=appRunning)

## Initialization


The Angular Application can be initialized as following:
```JavaScript
var app = angular.module('myApp', [DudeIntelligenceApiLib]);
// now controllers/services can be created which import
// the factories provided by the sdk
```
### Authentication
In order to setup authentication and initialization of the Angular App, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



```JavaScript
var app = angular.module('myApp', [DudeIntelligenceApiLib]);
app.factory('config', function($scope, Configuration) 
{
    return {
        setConfigVars: function() {
            // Configuration parameters and credentials
            Configuration.oAuthAccessToken = 'oAuthAccessToken'; // OAuth 2.0 Access Token
            
        }
    };
});
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SystemInformation](#system_information)
* [Heartbeat](#heartbeat)
* [ExecutiveSummaries](#executive_summaries)
* [ScheduledReports](#scheduled_reports)

## <a name="system_information"></a>![Class: ](https://apidocs.io/img/class.png ".SystemInformation") SystemInformation

### Get singleton instance

The singleton instance of the ``` SystemInformation ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, SystemInformation, SystemInformationModel){
	});
```

### <a name="get_system_information"></a>![Method: ](https://apidocs.io/img/method.png ".SystemInformation.getSystemInformation") getSystemInformation

> TODO: Add a method description


```javascript
function getSystemInformation()
```

#### Example Usage

```javascript


	app.controller("testController", function($scope, SystemInformation, SystemInformationModel){


		var result = SystemInformation.getSystemInformation();
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat"></a>![Class: ](https://apidocs.io/img/class.png ".Heartbeat") Heartbeat

### Get singleton instance

The singleton instance of the ``` Heartbeat ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, Heartbeat, HeartbeatModel){
	});
```

### <a name="get_heartbeat"></a>![Method: ](https://apidocs.io/img/method.png ".Heartbeat.getHeartbeat") getHeartbeat

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.


```javascript
function getHeartbeat()
```

#### Example Usage

```javascript


	app.controller("testController", function($scope, Heartbeat, HeartbeatModel){


		var result = Heartbeat.getHeartbeat();
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



[Back to List of Controllers](#list_of_controllers)

## <a name="executive_summaries"></a>![Class: ](https://apidocs.io/img/class.png ".ExecutiveSummaries") ExecutiveSummaries

### Get singleton instance

The singleton instance of the ``` ExecutiveSummaries ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, ExecutiveSummaries, GetSummaryCollectionResponseModel, ExecutiveSummaryDataModel){
	});
```

### <a name="get_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.getSummaryCollection") getSummaryCollection

> TODO: Add a method description


```javascript
function getSummaryCollection(input)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| type |  ``` Optional ```  | The type of records to filter by. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ExecutiveSummaries, GetSummaryCollectionResponseModel){
        var input = [];
        input['accountId'] = 1011;
        input['page'] = 1;
        input['pagesize'] = 1000;
        input['orderby'] = 'Name asc';
        input['type'] = '"Event"';


		var result = ExecutiveSummaries.getSummaryCollection(input);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



### <a name="post_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.postSummaryCollection") postSummaryCollection

> TODO: Add a method description


```javascript
function postSummaryCollection(input)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| body |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| type |  ``` Optional ```  | The type of records to filter by. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ExecutiveSummaries, ExecutiveSummaryDataModel){
        var input = [];
        input['accountId'] = 222;
        input['body'] = new ExecutiveSummaryDataModel({"key":"value"});
        input['page'] = 222;
        input['pagesize'] = 222;
        input['orderby'] = 'orderby';
        input['type'] = 'type';


		var result = ExecutiveSummaries.postSummaryCollection(input);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



### <a name="get_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.getSummaryCollectionDetail") getSummaryCollectionDetail

> TODO: Add a method description


```javascript
function getSummaryCollectionDetail(input)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ExecutiveSummaries, ExecutiveSummaryDataModel){
        var input = [];
        input['accountId'] = 1011;
        input['id'] = 1011;


		var result = ExecutiveSummaries.getSummaryCollectionDetail(input);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



### <a name="delete_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.deleteSummaryCollectionDetail") deleteSummaryCollectionDetail

> TODO: Add a method description


```javascript
function deleteSummaryCollectionDetail(input)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ExecutiveSummaries){
        var input = [];
        input['accountId'] = 1011;
        input['id'] = 1011;


		var result = ExecutiveSummaries.deleteSummaryCollectionDetail(input);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



[Back to List of Controllers](#list_of_controllers)

## <a name="scheduled_reports"></a>![Class: ](https://apidocs.io/img/class.png ".ScheduledReports") ScheduledReports

### Get singleton instance

The singleton instance of the ``` ScheduledReports ``` class can be accessed via Dependency Injection.

```js
	app.controller("testController", function($scope, ScheduledReports, GetScheduledReportsCollectionResponseModel, ScheduledReportDataModel){
	});
```

### <a name="get_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.getScheduledReportsCollection") getScheduledReportsCollection

> TODO: Add a method description


```javascript
function getScheduledReportsCollection(input)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ScheduledReports, GetScheduledReportsCollectionResponseModel){
        var input = [];
        input['accountId'] = 1011;
        input['page'] = 1;
        input['pagesize'] = 1000;
        input['orderby'] = 'Name asc';


		var result = ScheduledReports.getScheduledReportsCollection(input);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



### <a name="post_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.postScheduledReportsCollection") postScheduledReportsCollection

> TODO: Add a method description


```javascript
function postScheduledReportsCollection(input)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| body |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ScheduledReports, ScheduledReportDataModel){
        var input = [];
        input['accountId'] = 222;
        input['body'] = new ScheduledReportDataModel({"key":"value"});
        input['page'] = 222;
        input['pagesize'] = 222;
        input['orderby'] = 'orderby';


		var result = ScheduledReports.postScheduledReportsCollection(input);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



### <a name="get_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.getScheduledReportsCollectionDetail") getScheduledReportsCollectionDetail

> TODO: Add a method description


```javascript
function getScheduledReportsCollectionDetail(input)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ScheduledReports, ScheduledReportDataModel){
        var input = [];
        input['accountId'] = 1011;
        input['id'] = 1011;


		var result = ScheduledReports.getScheduledReportsCollectionDetail(input);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



### <a name="delete_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.deleteScheduledReportsCollectionDetail") deleteScheduledReportsCollectionDetail

> TODO: Add a method description


```javascript
function deleteScheduledReportsCollectionDetail(input)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |



#### Example Usage

```javascript


	app.controller("testController", function($scope, ScheduledReports){
        var input = [];
        input['accountId'] = 1011;
        input['id'] = 1011;


		var result = ScheduledReports.deleteScheduledReportsCollectionDetail(input);
        //Function call returns a promise
        result.then(function(success){
			//success case
			//getting context of response
			console.log(success.getContext());
		},function(err){
			//failure case
		});

	});
```



[Back to List of Controllers](#list_of_controllers)



