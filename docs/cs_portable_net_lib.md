# Getting started

TODO: Add a description

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (DudeIntelligenceApi.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Dude%20Intelligence%20Api-CSharp&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the DudeIntelligenceApi library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Dude%20Intelligence%20Api-CSharp&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Dude%20Intelligence%20Api-CSharp&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Dude%20Intelligence%20Api-CSharp&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi.Tests)

### 3. Add reference of the library project

In order to use the DudeIntelligenceApi library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Dude%20Intelligence%20Api-CSharp&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` DudeIntelligenceApi.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```DudeIntelligenceApi.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Dude%20Intelligence%20Api-CSharp&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Dude%20Intelligence%20Api-CSharp&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApi.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // OAuth 2.0 Access Token

DudeIntelligenceApiClient client = new DudeIntelligenceApiClient(oAuthAccessToken);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SystemInformation](#system_information)
* [Heartbeat](#heartbeat)
* [ExecutiveSummaries](#executive_summaries)
* [ScheduledReports](#scheduled_reports)

## <a name="system_information"></a>![Class: ](https://apidocs.io/img/class.png "DSI.SDK.Intelligence.Controllers.SystemInformation") SystemInformation

### Get singleton instance

The singleton instance of the ``` SystemInformation ``` class can be accessed from the API Client.

```csharp
ISystemInformation systemInformation = client.SystemInformation;
```

### <a name="get_system_information"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.SystemInformation.GetSystemInformation") GetSystemInformation

> TODO: Add a method description


```csharp
Task<SDK.Intelligence.Models.SystemInformationModel> GetSystemInformation()
```

#### Example Usage

```csharp

SDK.Intelligence.Models.SystemInformationModel result = await systemInformation.GetSystemInformation();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat"></a>![Class: ](https://apidocs.io/img/class.png "DSI.SDK.Intelligence.Controllers.Heartbeat") Heartbeat

### Get singleton instance

The singleton instance of the ``` Heartbeat ``` class can be accessed from the API Client.

```csharp
IHeartbeat heartbeat = client.Heartbeat;
```

### <a name="get_heartbeat"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.Heartbeat.GetHeartbeat") GetHeartbeat

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.


```csharp
Task<SDK.Intelligence.Models.HeartbeatModel> GetHeartbeat()
```

#### Example Usage

```csharp

SDK.Intelligence.Models.HeartbeatModel result = await heartbeat.GetHeartbeat();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="executive_summaries"></a>![Class: ](https://apidocs.io/img/class.png "DSI.SDK.Intelligence.Controllers.ExecutiveSummaries") ExecutiveSummaries

### Get singleton instance

The singleton instance of the ``` ExecutiveSummaries ``` class can be accessed from the API Client.

```csharp
IExecutiveSummaries executiveSummaries = client.ExecutiveSummaries;
```

### <a name="get_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.ExecutiveSummaries.GetSummaryCollection") GetSummaryCollection

> TODO: Add a method description


```csharp
Task<SDK.Intelligence.Models.GetSummaryCollectionResponseModel> GetSummaryCollection(SDK.Intelligence.Models.GetSummaryCollectionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| morderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| type |  ``` Optional ```  | The type of records to filter by. |


#### Example Usage

```csharp
GetSummaryCollectionInput collect = new GetSummaryCollectionInput();

int accountId = 1011;
collect.AccountId = accountId;

int? page = 1;
collect.Page = page;

int? pagesize = 1000;
collect.Pagesize = pagesize;

string morderby = "Name asc";
collect.Morderby = morderby;

string type = "\"Event\"";
collect.Type = type;


SDK.Intelligence.Models.GetSummaryCollectionResponseModel result = await executiveSummaries.GetSummaryCollection(collect);

```


### <a name="post_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.ExecutiveSummaries.PostSummaryCollection") PostSummaryCollection

> TODO: Add a method description


```csharp
Task<SDK.Intelligence.Models.ExecutiveSummaryDataModel> PostSummaryCollection(SDK.Intelligence.Models.PostSummaryCollectionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| body |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| morderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| type |  ``` Optional ```  | The type of records to filter by. |


#### Example Usage

```csharp
PostSummaryCollectionInput collect = new PostSummaryCollectionInput();

int accountId = 208;
collect.AccountId = accountId;

var body = new SDK.Intelligence.Models.ExecutiveSummaryDataModel();
collect.Body = body;

int? page = 208;
collect.Page = page;

int? pagesize = 208;
collect.Pagesize = pagesize;

string morderby = "orderby";
collect.Morderby = morderby;

string type = "type";
collect.Type = type;


SDK.Intelligence.Models.ExecutiveSummaryDataModel result = await executiveSummaries.PostSummaryCollection(collect);

```


### <a name="get_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.ExecutiveSummaries.GetSummaryCollectionDetail") GetSummaryCollectionDetail

> TODO: Add a method description


```csharp
Task<SDK.Intelligence.Models.ExecutiveSummaryDataModel> GetSummaryCollectionDetail(SDK.Intelligence.Models.GetSummaryCollectionDetailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |


#### Example Usage

```csharp
GetSummaryCollectionDetailInput collect = new GetSummaryCollectionDetailInput();

int accountId = 1011;
collect.AccountId = accountId;

int id = 1011;
collect.Id = id;


SDK.Intelligence.Models.ExecutiveSummaryDataModel result = await executiveSummaries.GetSummaryCollectionDetail(collect);

```


### <a name="delete_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.ExecutiveSummaries.DeleteSummaryCollectionDetail") DeleteSummaryCollectionDetail

> TODO: Add a method description


```csharp
Task DeleteSummaryCollectionDetail(SDK.Intelligence.Models.DeleteSummaryCollectionDetailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |


#### Example Usage

```csharp
DeleteSummaryCollectionDetailInput collect = new DeleteSummaryCollectionDetailInput();

int accountId = 1011;
collect.AccountId = accountId;

int id = 1011;
collect.Id = id;


await executiveSummaries.DeleteSummaryCollectionDetail(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="scheduled_reports"></a>![Class: ](https://apidocs.io/img/class.png "DSI.SDK.Intelligence.Controllers.ScheduledReports") ScheduledReports

### Get singleton instance

The singleton instance of the ``` ScheduledReports ``` class can be accessed from the API Client.

```csharp
IScheduledReports scheduledReports = client.ScheduledReports;
```

### <a name="get_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.ScheduledReports.GetScheduledReportsCollection") GetScheduledReportsCollection

> TODO: Add a method description


```csharp
Task<SDK.Intelligence.Models.GetScheduledReportsCollectionResponseModel> GetScheduledReportsCollection(SDK.Intelligence.Models.GetScheduledReportsCollectionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| morderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |


#### Example Usage

```csharp
GetScheduledReportsCollectionInput collect = new GetScheduledReportsCollectionInput();

int accountId = 1011;
collect.AccountId = accountId;

int? page = 1;
collect.Page = page;

int? pagesize = 1000;
collect.Pagesize = pagesize;

string morderby = "Name asc";
collect.Morderby = morderby;


SDK.Intelligence.Models.GetScheduledReportsCollectionResponseModel result = await scheduledReports.GetScheduledReportsCollection(collect);

```


### <a name="post_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.ScheduledReports.PostScheduledReportsCollection") PostScheduledReportsCollection

> TODO: Add a method description


```csharp
Task<SDK.Intelligence.Models.ScheduledReportDataModel> PostScheduledReportsCollection(SDK.Intelligence.Models.PostScheduledReportsCollectionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| body |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| morderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |


#### Example Usage

```csharp
PostScheduledReportsCollectionInput collect = new PostScheduledReportsCollectionInput();

int accountId = 208;
collect.AccountId = accountId;

var body = new SDK.Intelligence.Models.ScheduledReportDataModel();
collect.Body = body;

int? page = 208;
collect.Page = page;

int? pagesize = 208;
collect.Pagesize = pagesize;

string morderby = "orderby";
collect.Morderby = morderby;


SDK.Intelligence.Models.ScheduledReportDataModel result = await scheduledReports.PostScheduledReportsCollection(collect);

```


### <a name="get_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.ScheduledReports.GetScheduledReportsCollectionDetail") GetScheduledReportsCollectionDetail

> TODO: Add a method description


```csharp
Task<SDK.Intelligence.Models.ScheduledReportDataModel> GetScheduledReportsCollectionDetail(SDK.Intelligence.Models.GetScheduledReportsCollectionDetailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |


#### Example Usage

```csharp
GetScheduledReportsCollectionDetailInput collect = new GetScheduledReportsCollectionDetailInput();

int accountId = 1011;
collect.AccountId = accountId;

int id = 1011;
collect.Id = id;


SDK.Intelligence.Models.ScheduledReportDataModel result = await scheduledReports.GetScheduledReportsCollectionDetail(collect);

```


### <a name="delete_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png "DSI.SDK.Intelligence.Controllers.ScheduledReports.DeleteScheduledReportsCollectionDetail") DeleteScheduledReportsCollectionDetail

> TODO: Add a method description


```csharp
Task DeleteScheduledReportsCollectionDetail(SDK.Intelligence.Models.DeleteScheduledReportsCollectionDetailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |


#### Example Usage

```csharp
DeleteScheduledReportsCollectionDetailInput collect = new DeleteScheduledReportsCollectionDetailInput();

int accountId = 1011;
collect.AccountId = accountId;

int id = 1011;
collect.Id = id;


await scheduledReports.DeleteScheduledReportsCollectionDetail(collect);

```


[Back to List of Controllers](#list_of_controllers)



