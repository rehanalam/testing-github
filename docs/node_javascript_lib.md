# Getting started

TODO: Add a description

## How to Build

The generated SDK relies on [Node Package Manager](https://www.npmjs.com/) (NPM) being available to resolve dependencies. If you don't already have NPM installed, please go ahead and follow instructions to install NPM from [here](https://nodejs.org/en/download/).
The SDK also requires Node to be installed. If Node isn't already installed, please install it from [here](https://nodejs.org/en/download/)
> NPM is installed by default when Node is installed

To check if node and npm have been successfully installed, write the following commands in command prompt:
* `node --version`
* `npm -version` 
![Version Check](https://apidocs.io/illustration/nodejs?step=versionCheck&workspaceFolder=Dude%20Intelligence%20Api-Node)  

Now use npm to resolve all dependencies by running the following command in the root directory (of the SDK folder):
* `npm install`
![Resolve Dependencies](https://apidocs.io/illustration/nodejs?step=resolveDependency1&workspaceFolder=Dude%20Intelligence%20Api-Node)
![Resolve Dependencies](https://apidocs.io/illustration/nodejs?step=resolveDependency2)

This will install all dependencies in the `node_modules` folder. 

Once dependencies are resolved, you will need to move the folder `DudeIntelligenceApiLib ` in to your `node_modules` folder.

## How to Use

The following section explains how to use the library in a new project.

### 1. Open Project Folder
Open an IDE/Text Editor for JavaScript like Sublime Text. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.  
Click on `File` and select `Open Folder`
![Open Folder](https://apidocs.io/illustration/nodejs?step=openFolder)

Select the folder of your SDK and click on `Select Folder` to open it up in Sublime Text. The folder will become visible in the bar on the left.
![Open Project](https://apidocs.io/illustration/nodejs?step=openProject&workspaceFolder=Dude%20Intelligence%20Api-Node)


### 2. Creating a Test File
Now right click on the folder name and select the `New File` option to create a new test file.    Save it as `index.js` Now import the generated NodeJS library using the following lines of code:
```JavaScript
var lib = require('lib');
```
Save changes.

![Create new file](https://apidocs.io/illustration/nodejs?step=createNewFile&workspaceFolder=Dude%20Intelligence%20Api-Node)
![Save new file](https://apidocs.io/illustration/nodejs?step=saveNewFile&workspaceFolder=Dude%20Intelligence%20Api-Node)

### 3. Running The Test File
To run the `index.js` file, open up the command prompt and navigate to the Path where the SDK folder resides. Type the following command to run the file:  
`node index.js`
![Run file](https://apidocs.io/illustration/nodejs?step=runProject&workspaceFolder=Dude%20Intelligence%20Api-Node)


## How to Test

These tests use Mocha framework for testing, coupled with Chai for assertions. These dependencies need to be installed for tests to run.
Tests can be run in a number of ways:

### Method 1 
###### (Run all tests)

1. Navigate to the root directory of the SDK folder from command prompt.
2. Type `mocha --recursive` to run all the tests.

### Method 2
###### (Run all tests)

1. Navigate to the `../test/Controllers/` directory from command prompt.
2. Type `mocha *` to run all the tests.

### Method 3
###### (Run specific controller's tests)

1. Navigate to the `../test/Controllers/` directory from command prompt.
2. Type `mocha  Dude Intelligence ApiController`  to run all the tests in that controller file.

> To increase mocha's default timeout, you can change the `TEST_TIMEOUT` parameter's value in `TestBootstrap.js`.  

![Run Tests](https://apidocs.io/illustration/nodejs?step=runTests&controllerName=Dude%20Intelligence%20ApiController)

## Initialization

### Authentication
In order to setup authentication in the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



API client can be initialized as following:

```JavaScript
const lib = require('lib');

// Configuration parameters and credentials
lib.Configuration.oAuthAccessToken = "oAuthAccessToken"; // OAuth 2.0 Access Token

```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SystemInformation](#system_information)
* [Heartbeat](#heartbeat)
* [ExecutiveSummaries](#executive_summaries)
* [ScheduledReports](#scheduled_reports)

## <a name="system_information"></a>![Class: ](https://apidocs.io/img/class.png ".SystemInformation") SystemInformation

### Get singleton instance

The singleton instance of the ``` SystemInformation ``` class can be accessed from the API Client.

```javascript
var controller = lib.SystemInformation;
```

### <a name="get_system_information"></a>![Method: ](https://apidocs.io/img/method.png ".SystemInformation.getSystemInformation") getSystemInformation

> TODO: Add a method description


```javascript
function getSystemInformation(callback)
```

#### Example Usage

```javascript


    controller.getSystemInformation(function(error, response, context) {

    
	});
```



[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat"></a>![Class: ](https://apidocs.io/img/class.png ".Heartbeat") Heartbeat

### Get singleton instance

The singleton instance of the ``` Heartbeat ``` class can be accessed from the API Client.

```javascript
var controller = lib.Heartbeat;
```

### <a name="get_heartbeat"></a>![Method: ](https://apidocs.io/img/method.png ".Heartbeat.getHeartbeat") getHeartbeat

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.


```javascript
function getHeartbeat(callback)
```

#### Example Usage

```javascript


    controller.getHeartbeat(function(error, response, context) {

    
	});
```



[Back to List of Controllers](#list_of_controllers)

## <a name="executive_summaries"></a>![Class: ](https://apidocs.io/img/class.png ".ExecutiveSummaries") ExecutiveSummaries

### Get singleton instance

The singleton instance of the ``` ExecutiveSummaries ``` class can be accessed from the API Client.

```javascript
var controller = lib.ExecutiveSummaries;
```

### <a name="get_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.getSummaryCollection") getSummaryCollection

> TODO: Add a method description


```javascript
function getSummaryCollection(input, callback)
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

    var input = [];
        input['accountId'] = 1011;
        input['page'] = 1;
        input['pagesize'] = 1000;
        input['orderby'] = 'Name asc';
        input['type'] = '"Event"';

    controller.getSummaryCollection(input, function(error, response, context) {

    
	});
```



### <a name="post_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.postSummaryCollection") postSummaryCollection

> TODO: Add a method description


```javascript
function postSummaryCollection(input, callback)
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

    var input = [];
        input['accountId'] = 108;
        input['body'] = new ExecutiveSummaryDataModel({"key":"value"});
        input['page'] = 108;
        input['pagesize'] = 108;
        input['orderby'] = 'orderby';
        input['type'] = 'type';

    controller.postSummaryCollection(input, function(error, response, context) {

    
	});
```



### <a name="get_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.getSummaryCollectionDetail") getSummaryCollectionDetail

> TODO: Add a method description


```javascript
function getSummaryCollectionDetail(input, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |



#### Example Usage

```javascript

    var input = [];
        input['accountId'] = 1011;
        input['id'] = 1011;

    controller.getSummaryCollectionDetail(input, function(error, response, context) {

    
	});
```



### <a name="delete_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.deleteSummaryCollectionDetail") deleteSummaryCollectionDetail

> TODO: Add a method description


```javascript
function deleteSummaryCollectionDetail(input, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |



#### Example Usage

```javascript

    var input = [];
        input['accountId'] = 1011;
        input['id'] = 1011;

    controller.deleteSummaryCollectionDetail(input, function(error, response, context) {

    
	});
```



[Back to List of Controllers](#list_of_controllers)

## <a name="scheduled_reports"></a>![Class: ](https://apidocs.io/img/class.png ".ScheduledReports") ScheduledReports

### Get singleton instance

The singleton instance of the ``` ScheduledReports ``` class can be accessed from the API Client.

```javascript
var controller = lib.ScheduledReports;
```

### <a name="get_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.getScheduledReportsCollection") getScheduledReportsCollection

> TODO: Add a method description


```javascript
function getScheduledReportsCollection(input, callback)
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

    var input = [];
        input['accountId'] = 1011;
        input['page'] = 1;
        input['pagesize'] = 1000;
        input['orderby'] = 'Name asc';

    controller.getScheduledReportsCollection(input, function(error, response, context) {

    
	});
```



### <a name="post_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.postScheduledReportsCollection") postScheduledReportsCollection

> TODO: Add a method description


```javascript
function postScheduledReportsCollection(input, callback)
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

    var input = [];
        input['accountId'] = 108;
        input['body'] = new ScheduledReportDataModel({"key":"value"});
        input['page'] = 108;
        input['pagesize'] = 108;
        input['orderby'] = 'orderby';

    controller.postScheduledReportsCollection(input, function(error, response, context) {

    
	});
```



### <a name="get_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.getScheduledReportsCollectionDetail") getScheduledReportsCollectionDetail

> TODO: Add a method description


```javascript
function getScheduledReportsCollectionDetail(input, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |



#### Example Usage

```javascript

    var input = [];
        input['accountId'] = 1011;
        input['id'] = 1011;

    controller.getScheduledReportsCollectionDetail(input, function(error, response, context) {

    
	});
```



### <a name="delete_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.deleteScheduledReportsCollectionDetail") deleteScheduledReportsCollectionDetail

> TODO: Add a method description


```javascript
function deleteScheduledReportsCollectionDetail(input, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |



#### Example Usage

```javascript

    var input = [];
        input['accountId'] = 1011;
        input['id'] = 1011;

    controller.deleteScheduledReportsCollectionDetail(input, function(error, response, context) {

    
	});
```



[Back to List of Controllers](#list_of_controllers)



