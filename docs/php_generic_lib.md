# Getting started

TODO: Add a description

## How to Build

The generated code has dependencies over external libraries like UniRest. These dependencies are defined in the ```composer.json``` file that comes with the SDK. 
To resolve these dependencies, we use the Composer package manager which requires PHP greater than 5.3.2 installed in your system. 
Visit [https://getcomposer.org/download/](https://getcomposer.org/download/) to download the installer file for Composer and run it in your system. 
Open command prompt and type ```composer --version```. This should display the current version of the Composer installed if the installation was successful.

* Using command line, navigate to the directory containing the generated files (including ```composer.json```) for the SDK. 
* Run the command ```composer install```. This should install all the required dependencies and create the ```vendor``` directory in your project directory.

![Building SDK - Step 1](https://apidocs.io/illustration/php?step=installDependencies&workspaceFolder=Dude%20Intelligence%20Api-PHP)

### [For Windows Users Only] Configuring CURL Certificate Path in php.ini

CURL used to include a list of accepted CAs, but no longer bundles ANY CA certs. So by default it will reject all SSL certificates as unverifiable. You will have to get your CA's cert and point curl at it. The steps are as follows:

1. Download the certificate bundle (.pem file) from [https://curl.haxx.se/docs/caextract.html](https://curl.haxx.se/docs/caextract.html) on to your system.
2. Add curl.cainfo = "PATH_TO/cacert.pem" to your php.ini file located in your php installation. “PATH_TO” must be an absolute path containing the .pem file.

```ini
[curl]
; A default value for the CURLOPT_CAINFO option. This is required to be an
; absolute path.
;curl.cainfo =
```

## How to Use

The following section explains how to use the DudeIntelligenceApi library in a new project.

### 1. Open Project in an IDE

Open an IDE for PHP like PhpStorm. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

![Open project in PHPStorm - Step 1](https://apidocs.io/illustration/php?step=openIDE&workspaceFolder=Dude%20Intelligence%20Api-PHP)

Click on ```Open``` in PhpStorm to browse to your generated SDK directory and then click ```OK```.

![Open project in PHPStorm - Step 2](https://apidocs.io/illustration/php?step=openProject0&workspaceFolder=Dude%20Intelligence%20Api-PHP)     

### 2. Add a new Test Project

Create a new directory by right clicking on the solution name as shown below:

![Add a new project in PHPStorm - Step 1](https://apidocs.io/illustration/php?step=createDirectory&workspaceFolder=Dude%20Intelligence%20Api-PHP)

Name the directory as "test"

![Add a new project in PHPStorm - Step 2](https://apidocs.io/illustration/php?step=nameDirectory&workspaceFolder=Dude%20Intelligence%20Api-PHP)
   
Add a PHP file to this project

![Add a new project in PHPStorm - Step 3](https://apidocs.io/illustration/php?step=createFile&workspaceFolder=Dude%20Intelligence%20Api-PHP)

Name it "testSDK"

![Add a new project in PHPStorm - Step 4](https://apidocs.io/illustration/php?step=nameFile&workspaceFolder=Dude%20Intelligence%20Api-PHP)

Depending on your project setup, you might need to include composer's autoloader in your PHP code to enable auto loading of classes.

```PHP
require_once "../vendor/autoload.php";
```

It is important that the path inside require_once correctly points to the file ```autoload.php``` inside the vendor directory created during dependency installations.

![Add a new project in PHPStorm - Step 4](https://apidocs.io/illustration/php?step=projectFiles&workspaceFolder=Dude%20Intelligence%20Api-PHP)

After this you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

### 3. Run the Test Project

To run your project you must set the Interpreter for your project. Interpreter is the PHP engine installed on your computer.

Open ```Settings``` from ```File``` menu.

![Run Test Project - Step 1](https://apidocs.io/illustration/php?step=openSettings&workspaceFolder=Dude%20Intelligence%20Api-PHP)

Select ```PHP``` from within ```Languages & Frameworks```

![Run Test Project - Step 2](https://apidocs.io/illustration/php?step=setInterpreter0&workspaceFolder=Dude%20Intelligence%20Api-PHP)

Browse for Interpreters near the ```Interpreter``` option and choose your interpreter.

![Run Test Project - Step 3](https://apidocs.io/illustration/php?step=setInterpreter1&workspaceFolder=Dude%20Intelligence%20Api-PHP)

Once the interpreter is selected, click ```OK```

![Run Test Project - Step 4](https://apidocs.io/illustration/php?step=setInterpreter2&workspaceFolder=Dude%20Intelligence%20Api-PHP)

To run your project, right click on your PHP file inside your Test project and click on ```Run```

![Run Test Project - Step 5](https://apidocs.io/illustration/php?step=runProject&workspaceFolder=Dude%20Intelligence%20Api-PHP)

## How to Test

Unit tests in this SDK can be run using PHPUnit. 

1. First install the dependencies using composer including the `require-dev` dependencies.
2. Run `vendor\bin\phpunit --verbose` from commandline to execute tests. If you have 
   installed PHPUnit globally, run tests using `phpunit --verbose` instead.

You can change the PHPUnit test configuration in the `phpunit.xml` file.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



API client can be initialized as following.

```php
$oAuthAccessToken = 'oAuthAccessToken'; // OAuth 2.0 Access Token

$client = new DudeIntelligenceApiLib\DudeIntelligenceApiClient($oAuthAccessToken);
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

```php
$systemInformation = $client->getSystemInformation();
```

### <a name="get_system_information"></a>![Method: ](https://apidocs.io/img/method.png ".SystemInformation.getSystemInformation") getSystemInformation

> TODO: Add a method description


```php
function getSystemInformation()
```

#### Example Usage

```php

$result = $systemInformation->getSystemInformation();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat"></a>![Class: ](https://apidocs.io/img/class.png ".Heartbeat") Heartbeat

### Get singleton instance

The singleton instance of the ``` Heartbeat ``` class can be accessed from the API Client.

```php
$heartbeat = $client->getHeartbeat();
```

### <a name="get_heartbeat"></a>![Method: ](https://apidocs.io/img/method.png ".Heartbeat.getHeartbeat") getHeartbeat

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.


```php
function getHeartbeat()
```

#### Example Usage

```php

$result = $heartbeat->getHeartbeat();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="executive_summaries"></a>![Class: ](https://apidocs.io/img/class.png ".ExecutiveSummaries") ExecutiveSummaries

### Get singleton instance

The singleton instance of the ``` ExecutiveSummaries ``` class can be accessed from the API Client.

```php
$executiveSummaries = $client->getExecutiveSummaries();
```

### <a name="get_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.getSummaryCollection") getSummaryCollection

> TODO: Add a method description


```php
function getSummaryCollection($options)
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

```php
$accountId = 1011;
$collect['accountId'] = $accountId;

$page = 1;
$collect['page'] = $page;

$pagesize = 1000;
$collect['pagesize'] = $pagesize;

$orderby = 'Name asc';
$collect['orderby'] = $orderby;

$type = '"Event"';
$collect['type'] = $type;


$result = $executiveSummaries->getSummaryCollection($collect);

```


### <a name="post_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.postSummaryCollection") postSummaryCollection

> TODO: Add a method description


```php
function postSummaryCollection($options)
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

```php
$accountId = 85;
$collect['accountId'] = $accountId;

$body = new ExecutiveSummaryDataModel();
$collect['body'] = $body;

$page = 85;
$collect['page'] = $page;

$pagesize = 85;
$collect['pagesize'] = $pagesize;

$orderby = 'orderby';
$collect['orderby'] = $orderby;

$type = 'type';
$collect['type'] = $type;


$result = $executiveSummaries->postSummaryCollection($collect);

```


### <a name="get_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.getSummaryCollectionDetail") getSummaryCollectionDetail

> TODO: Add a method description


```php
function getSummaryCollectionDetail($options)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |



#### Example Usage

```php
$accountId = 1011;
$collect['accountId'] = $accountId;

$id = 1011;
$collect['id'] = $id;


$result = $executiveSummaries->getSummaryCollectionDetail($collect);

```


### <a name="delete_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.deleteSummaryCollectionDetail") deleteSummaryCollectionDetail

> TODO: Add a method description


```php
function deleteSummaryCollectionDetail($options)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |



#### Example Usage

```php
$accountId = 1011;
$collect['accountId'] = $accountId;

$id = 1011;
$collect['id'] = $id;


$executiveSummaries->deleteSummaryCollectionDetail($collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="scheduled_reports"></a>![Class: ](https://apidocs.io/img/class.png ".ScheduledReports") ScheduledReports

### Get singleton instance

The singleton instance of the ``` ScheduledReports ``` class can be accessed from the API Client.

```php
$scheduledReports = $client->getScheduledReports();
```

### <a name="get_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.getScheduledReportsCollection") getScheduledReportsCollection

> TODO: Add a method description


```php
function getScheduledReportsCollection($options)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |



#### Example Usage

```php
$accountId = 1011;
$collect['accountId'] = $accountId;

$page = 1;
$collect['page'] = $page;

$pagesize = 1000;
$collect['pagesize'] = $pagesize;

$orderby = 'Name asc';
$collect['orderby'] = $orderby;


$result = $scheduledReports->getScheduledReportsCollection($collect);

```


### <a name="post_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.postScheduledReportsCollection") postScheduledReportsCollection

> TODO: Add a method description


```php
function postScheduledReportsCollection($options)
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

```php
$accountId = 85;
$collect['accountId'] = $accountId;

$body = new ScheduledReportDataModel();
$collect['body'] = $body;

$page = 85;
$collect['page'] = $page;

$pagesize = 85;
$collect['pagesize'] = $pagesize;

$orderby = 'orderby';
$collect['orderby'] = $orderby;


$result = $scheduledReports->postScheduledReportsCollection($collect);

```


### <a name="get_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.getScheduledReportsCollectionDetail") getScheduledReportsCollectionDetail

> TODO: Add a method description


```php
function getScheduledReportsCollectionDetail($options)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |



#### Example Usage

```php
$accountId = 1011;
$collect['accountId'] = $accountId;

$id = 1011;
$collect['id'] = $id;


$result = $scheduledReports->getScheduledReportsCollectionDetail($collect);

```


### <a name="delete_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.deleteScheduledReportsCollectionDetail") deleteScheduledReportsCollectionDetail

> TODO: Add a method description


```php
function deleteScheduledReportsCollectionDetail($options)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |



#### Example Usage

```php
$accountId = 1011;
$collect['accountId'] = $accountId;

$id = 1011;
$collect['id'] = $id;


$scheduledReports->deleteScheduledReportsCollectionDetail($collect);

```


[Back to List of Controllers](#list_of_controllers)



