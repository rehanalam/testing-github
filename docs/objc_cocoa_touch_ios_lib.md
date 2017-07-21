# Getting started

TODO: Add a description

## How to Build


The generated code has dependencies over external libraries like UniRest. These dependencies are defined in the ```PodFile``` file that comes with the SDK. 
To resolve these dependencies, we use the Cocoapods package manager.
Visit https://guides.cocoapods.org/using/getting-started.html to setup Cocoapods on your system.
Open command prompt and type ```pod --version```. This should display the current version of Cocoapods installed if the installation was successful.

Using command line, navigate to the directory containing the generated files (including ```PodFile```) for the SDK. 
Run the command ```pod install```. This should install all the required dependencies and create the ```pods``` directory in your project directory.

![Installing dependencies using Cocoapods](https://apidocs.io/illustration/objc?step=AddDependencies&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)

Open the project workspace using the (DudeIntelligenceApi.xcworkspace) file. Invoke the build process using `Command(⌘)+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Xcode](https://apidocs.io/illustration/objc?step=BuildSDK&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)


## How to Use

The generated code is a Cocoa Touch Static Library which can be used in any iOS project. The support for these generated libraries go all the way back to iOS 6.

The following section explains how to use the DudeIntelligenceApi library in a new iOS project.     
### 1. Starting a new project
To start a new project, left-click on the ```Create a new Xcode project```.
![Create Test Project - Step 1](https://apidocs.io/illustration/objc?step=Test1&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)

Next, choose **Single View Application** and click ```Next```.
![Create Test Project - Step 2](https://apidocs.io/illustration/objc?step=Test2&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)

Provide **Test-Project** as the product name click ```Next```.
![Create Test Project - Step 3](https://apidocs.io/illustration/objc?step=Test3&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)

Choose the desired location of your project folder and click ```Create```.
![Create Test Project - Step 4](https://apidocs.io/illustration/objc?step=Test4&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)

### 2. Adding the static library dependency
To add this dependency open a terminal and navigate to your project folder. Next, input ```pod init``` and press enter.
![Add dependency - Step 1](https://apidocs.io/illustration/objc?step=Add0&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)

Next, open the newly created ```PodFile``` in your favourite text editor. Add the following line : pod 'DudeIntelligenceApi', :path => 'Vendor/DudeIntelligenceApi'
![Add dependency - Step 2](https://apidocs.io/illustration/objc?step=Add1&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)

Execute `pod install` from terminal to install the dependecy in your project. This would add the dependency to the newly created test project.
![Add dependency - Step 3](https://apidocs.io/illustration/objc?step=Add2&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)


## How to Test

Unit tests in this SDK can be run using Xcode. 

First build the SDK as shown in the steps above and naivgate to the project directory and open the DudeIntelligenceApi.xcworkspace file.

Go to the test explorer in Xcode as shown in the picture below and click on `run tests` from the menu. 
![Run tests](https://apidocs.io/illustration/objc?step=RunTests&workspaceFolder=Dude%20Intelligence%20Api-ObjC&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi&rootNamespace=DudeIntelligenceApi)


## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



Configuration variables can be set as following.
```Objc
// Configuration parameters and credentials
Configuration_OAuthAccessToken = "Configuration_OAuthAccessToken"; // OAuth 2.0 Access Token

```

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SystemInformation](#system_information)
* [Heartbeat](#heartbeat)
* [ExecutiveSummaries](#executive_summaries)
* [ScheduledReports](#scheduled_reports)

## <a name="system_information"></a>![Class: ](https://apidocs.io/img/class.png ".SystemInformation") SystemInformation

### Get singleton instance
```objc
SystemInformation* systemInformation = [[SystemInformation alloc]init] ;
```

### <a name="get_system_information_with_completion_block"></a>![Method: ](https://apidocs.io/img/method.png ".SystemInformation.getSystemInformationWithCompletionBlock") getSystemInformationWithCompletionBlock

> TODO: Add a method description


```objc
function getSystemInformationWithCompletionBlock:(CompletedGetSystemInformation) onCompleted()
```



#### Example Usage

```objc

    [self.systemInformation getSystemInformationWithCompletionBlock:  ^(BOOL success, HttpContext* context, SystemInformationModel* response, NSError* error) { 
       //Add code here
    }];
```


[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat"></a>![Class: ](https://apidocs.io/img/class.png ".Heartbeat") Heartbeat

### Get singleton instance
```objc
Heartbeat* heartbeat = [[Heartbeat alloc]init] ;
```

### <a name="get_heartbeat_with_completion_block"></a>![Method: ](https://apidocs.io/img/method.png ".Heartbeat.getHeartbeatWithCompletionBlock") getHeartbeatWithCompletionBlock

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.


```objc
function getHeartbeatWithCompletionBlock:(CompletedGetHeartbeat) onCompleted()
```



#### Example Usage

```objc

    [self.heartbeat getHeartbeatWithCompletionBlock:  ^(BOOL success, HttpContext* context, HeartbeatModel* response, NSError* error) { 
       //Add code here
    }];
```


[Back to List of Controllers](#list_of_controllers)

## <a name="executive_summaries"></a>![Class: ](https://apidocs.io/img/class.png ".ExecutiveSummaries") ExecutiveSummaries

### Get singleton instance
```objc
ExecutiveSummaries* executiveSummaries = [[ExecutiveSummaries alloc]init] ;
```

### <a name="get_summary_collection_async_with_get_summary_collection_input"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.getSummaryCollectionAsyncWithGetSummaryCollectionInput") getSummaryCollectionAsyncWithGetSummaryCollectionInput

> TODO: Add a method description


```objc
function getSummaryCollectionAsyncWithGetSummaryCollectionInput:(GetSummaryCollectionInput*) input
                completionBlock:(CompletedGetSummaryCollection) onCompleted(input)
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

```objc
    // Parameters for the API call
    GetSummaryCollectionInput *input = [[GetSummaryCollectionInput alloc]init];
    input.accountId = [@"1011" intValue];
    input.page = [NSNumber numberWithInteger:[@"1" integerValue]];
    input.pagesize = [NSNumber numberWithInteger:[@"1000" integerValue]];
    input.orderby = @"Name asc";
    input.type = @"\"Event\"";

    [self.executiveSummaries getSummaryCollectionAsyncWithGetSummaryCollectionInput: input completionBlock:^(BOOL success, HttpContext* context, GetSummaryCollectionResponseModel* response, NSError* error) { 
       //Add code here
    }];
```


### <a name="post_summary_collection_async_with_post_summary_collection_input"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.postSummaryCollectionAsyncWithPostSummaryCollectionInput") postSummaryCollectionAsyncWithPostSummaryCollectionInput

> TODO: Add a method description


```objc
function postSummaryCollectionAsyncWithPostSummaryCollectionInput:(PostSummaryCollectionInput*) input
                completionBlock:(CompletedPostSummaryCollection) onCompleted(input)
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

```objc
    // Parameters for the API call
    PostSummaryCollectionInput *input = [[PostSummaryCollectionInput alloc]init];
    input.accountId = 244;
    input.body = [[ExecutiveSummaryDataModel alloc]init];
    input.page = 244;
    input.pagesize = 244;
    input.orderby = @"orderby";
    input.type = @"type";

    [self.executiveSummaries postSummaryCollectionAsyncWithPostSummaryCollectionInput: input completionBlock:^(BOOL success, HttpContext* context, ExecutiveSummaryDataModel* response, NSError* error) { 
       //Add code here
    }];
```


### <a name="get_summary_collection_detail_async_with_get_summary_collection_detail_input"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.getSummaryCollectionDetailAsyncWithGetSummaryCollectionDetailInput") getSummaryCollectionDetailAsyncWithGetSummaryCollectionDetailInput

> TODO: Add a method description


```objc
function getSummaryCollectionDetailAsyncWithGetSummaryCollectionDetailInput:(GetSummaryCollectionDetailInput*) input
                completionBlock:(CompletedGetSummaryCollectionDetail) onCompleted(input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| mid |  ``` Required ```  | Id of the execute summary to be retrieved. |





#### Example Usage

```objc
    // Parameters for the API call
    GetSummaryCollectionDetailInput *input = [[GetSummaryCollectionDetailInput alloc]init];
    input.accountId = [@"1011" intValue];
    input.mid = [@"1011" intValue];

    [self.executiveSummaries getSummaryCollectionDetailAsyncWithGetSummaryCollectionDetailInput: input completionBlock:^(BOOL success, HttpContext* context, ExecutiveSummaryDataModel* response, NSError* error) { 
       //Add code here
    }];
```


### <a name="delete_summary_collection_detail_async_with_delete_summary_collection_detail_input"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.deleteSummaryCollectionDetailAsyncWithDeleteSummaryCollectionDetailInput") deleteSummaryCollectionDetailAsyncWithDeleteSummaryCollectionDetailInput

> TODO: Add a method description


```objc
function deleteSummaryCollectionDetailAsyncWithDeleteSummaryCollectionDetailInput:(DeleteSummaryCollectionDetailInput*) input
                completionBlock:(CompletedDeleteSummaryCollectionDetail) onCompleted(input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| mid |  ``` Required ```  | Id of the execute summary to be retrieved. |





#### Example Usage

```objc
    // Parameters for the API call
    DeleteSummaryCollectionDetailInput *input = [[DeleteSummaryCollectionDetailInput alloc]init];
    input.accountId = [@"1011" intValue];
    input.mid = [@"1011" intValue];

    [self.executiveSummaries deleteSummaryCollectionDetailAsyncWithDeleteSummaryCollectionDetailInput: input completionBlock:^(BOOL success, HttpContext* context, NSError* error) { 
       //Add code here
    }];
```


[Back to List of Controllers](#list_of_controllers)

## <a name="scheduled_reports"></a>![Class: ](https://apidocs.io/img/class.png ".ScheduledReports") ScheduledReports

### Get singleton instance
```objc
ScheduledReports* scheduledReports = [[ScheduledReports alloc]init] ;
```

### <a name="get_scheduled_reports_collection_async_with_get_scheduled_reports_collection_input"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.getScheduledReportsCollectionAsyncWithGetScheduledReportsCollectionInput") getScheduledReportsCollectionAsyncWithGetScheduledReportsCollectionInput

> TODO: Add a method description


```objc
function getScheduledReportsCollectionAsyncWithGetScheduledReportsCollectionInput:(GetScheduledReportsCollectionInput*) input
                completionBlock:(CompletedGetScheduledReportsCollection) onCompleted(input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |





#### Example Usage

```objc
    // Parameters for the API call
    GetScheduledReportsCollectionInput *input = [[GetScheduledReportsCollectionInput alloc]init];
    input.accountId = [@"1011" intValue];
    input.page = [NSNumber numberWithInteger:[@"1" integerValue]];
    input.pagesize = [NSNumber numberWithInteger:[@"1000" integerValue]];
    input.orderby = @"Name asc";

    [self.scheduledReports getScheduledReportsCollectionAsyncWithGetScheduledReportsCollectionInput: input completionBlock:^(BOOL success, HttpContext* context, GetScheduledReportsCollectionResponseModel* response, NSError* error) { 
       //Add code here
    }];
```


### <a name="post_scheduled_reports_collection_async_with_post_scheduled_reports_collection_input"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.postScheduledReportsCollectionAsyncWithPostScheduledReportsCollectionInput") postScheduledReportsCollectionAsyncWithPostScheduledReportsCollectionInput

> TODO: Add a method description


```objc
function postScheduledReportsCollectionAsyncWithPostScheduledReportsCollectionInput:(PostScheduledReportsCollectionInput*) input
                completionBlock:(CompletedPostScheduledReportsCollection) onCompleted(input)
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

```objc
    // Parameters for the API call
    PostScheduledReportsCollectionInput *input = [[PostScheduledReportsCollectionInput alloc]init];
    input.accountId = 244;
    input.body = [[ScheduledReportDataModel alloc]init];
    input.page = 244;
    input.pagesize = 244;
    input.orderby = @"orderby";

    [self.scheduledReports postScheduledReportsCollectionAsyncWithPostScheduledReportsCollectionInput: input completionBlock:^(BOOL success, HttpContext* context, ScheduledReportDataModel* response, NSError* error) { 
       //Add code here
    }];
```


### <a name="get_scheduled_reports_collection_detail_async_with_get_scheduled_reports_collection_detail_input"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.getScheduledReportsCollectionDetailAsyncWithGetScheduledReportsCollectionDetailInput") getScheduledReportsCollectionDetailAsyncWithGetScheduledReportsCollectionDetailInput

> TODO: Add a method description


```objc
function getScheduledReportsCollectionDetailAsyncWithGetScheduledReportsCollectionDetailInput:(GetScheduledReportsCollectionDetailInput*) input
                completionBlock:(CompletedGetScheduledReportsCollectionDetail) onCompleted(input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| mid |  ``` Required ```  | Id of the scheduled report to be retrieved. |





#### Example Usage

```objc
    // Parameters for the API call
    GetScheduledReportsCollectionDetailInput *input = [[GetScheduledReportsCollectionDetailInput alloc]init];
    input.accountId = [@"1011" intValue];
    input.mid = [@"1011" intValue];

    [self.scheduledReports getScheduledReportsCollectionDetailAsyncWithGetScheduledReportsCollectionDetailInput: input completionBlock:^(BOOL success, HttpContext* context, ScheduledReportDataModel* response, NSError* error) { 
       //Add code here
    }];
```


### <a name="delete_scheduled_reports_collection_detail_async_with_delete_scheduled_reports_collection_detail_input"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.deleteScheduledReportsCollectionDetailAsyncWithDeleteScheduledReportsCollectionDetailInput") deleteScheduledReportsCollectionDetailAsyncWithDeleteScheduledReportsCollectionDetailInput

> TODO: Add a method description


```objc
function deleteScheduledReportsCollectionDetailAsyncWithDeleteScheduledReportsCollectionDetailInput:(DeleteScheduledReportsCollectionDetailInput*) input
                completionBlock:(CompletedDeleteScheduledReportsCollectionDetail) onCompleted(input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| mid |  ``` Required ```  | Id of the scheduled report to be retrieved. |





#### Example Usage

```objc
    // Parameters for the API call
    DeleteScheduledReportsCollectionDetailInput *input = [[DeleteScheduledReportsCollectionDetailInput alloc]init];
    input.accountId = [@"1011" intValue];
    input.mid = [@"1011" intValue];

    [self.scheduledReports deleteScheduledReportsCollectionDetailAsyncWithDeleteScheduledReportsCollectionDetailInput: input completionBlock:^(BOOL success, HttpContext* context, NSError* error) { 
       //Add code here
    }];
```


[Back to List of Controllers](#list_of_controllers)



