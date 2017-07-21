# Getting started

TODO: Add a description

## How to Build

The generated code uses a few Maven dependencies e.g., Jackson, UniRest,
and Apache HttpClient. The reference to these dependencies is already
added in the pom.xml file will be installed automatically. Therefore,
you will need internet access for a successful build.

* In order to open the client library in Eclipse click on ``` File -> Import ```.

![Importing SDK into Eclipse - Step 1](https://apidocs.io/illustration/java?step=import0&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

* In the import dialog, select ``` Existing Java Project ``` and click ``` Next ```.

![Importing SDK into Eclipse - Step 2](https://apidocs.io/illustration/java?step=import1&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

* Browse to locate the folder containing the source code. Select the detected location of the project and click ``` Finish ```.

![Importing SDK into Eclipse - Step 3](https://apidocs.io/illustration/java?step=import2&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

* Upon successful import, the project will be automatically built by Eclipse after automatically resolving the dependencies.

![Importing SDK into Eclipse - Step 4](https://apidocs.io/illustration/java?step=import3&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

## How to Use

The following section explains how to use the DudeIntelligenceApi library in a new console project.

### 1. Starting a new project

For starting a new project, click the menu command ``` File > New > Project ```.

![Add a new project in Eclipse](https://apidocs.io/illustration/java?step=createNewProject0&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

Next, choose ``` Maven > Maven Project ```and click ``` Next ```.

![Create a new Maven Project - Step 1](https://apidocs.io/illustration/java?step=createNewProject1&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

Here, make sure to use the current workspace by choosing ``` Use default Workspace location ```, as shown in the picture below and click ``` Next ```.

![Create a new Maven Project - Step 2](https://apidocs.io/illustration/java?step=createNewProject2&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

Following this, select the *quick start* project type to create a simple project with an existing class and a ``` main ``` method. To do this, choose ``` maven-archetype-quickstart ``` item from the list and click ``` Next ```.

![Create a new Maven Project - Step 3](https://apidocs.io/illustration/java?step=createNewProject3&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

In the last step, provide a ``` Group Id ``` and ``` Artifact Id ``` as shown in the picture below and click ``` Finish ```.

![Create a new Maven Project - Step 4](https://apidocs.io/illustration/java?step=createNewProject4&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

### 2. Add reference of the library project

The created Maven project manages its dependencies using its ``` pom.xml ``` file. In order to add a dependency on the *DudeIntelligenceApiLib* client library, double click on the ``` pom.xml ``` file in the ``` Package Explorer ```. Opening the ``` pom.xml ``` file will render a graphical view on the cavas. Here, switch to the ``` Dependencies ``` tab and click the ``` Add ``` button as shown in the picture below.

![Adding dependency to the client library - Step 1](https://apidocs.io/illustration/java?step=testProject0&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

Clicking the ``` Add ``` button will open a dialog where you need to specify DudeIntelligenceApi in ``` Group Id ``` and DudeIntelligenceApiLib in the ``` Artifact Id ``` fields. Once added click ``` OK ```. Save the ``` pom.xml ``` file.

![Adding dependency to the client library - Step 2](https://apidocs.io/illustration/java?step=testProject1&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

### 3. Write sample code

Once the ``` SimpleConsoleApp ``` is created, a file named ``` App.java ``` will be visible in the *Package Explorer* with a ``` main ``` method. This is the entry point for the execution of the created project.
Here, you can add code to initialize the client library and instantiate a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Adding dependency to the client library - Step 2](https://apidocs.io/illustration/java?step=testProject2&workspaceFolder=Dude%20Intelligence%20Api-Java&workspaceName=DudeIntelligenceApi&projectName=DudeIntelligenceApiLib&rootNamespace=io.dudesolutions.Intelligence)

## How to Test

The generated code and the server can be tested using automatically generated test cases. 
JUnit is used as the testing framework and test runner.

In Eclipse, for running the tests do the following:

1. Select the project *DudeIntelligenceApiLib* from the package explorer.
2. Select "Run -> Run as -> JUnit Test" or use "Alt + Shift + X" followed by "T" to run the Tests.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



API client can be initialized as following.

```java
// Configuration parameters and credentials
String oAuthAccessToken = "oAuthAccessToken"; // OAuth 2.0 Access Token

DudeIntelligenceApiClient client = new DudeIntelligenceApiClient(oAuthAccessToken);
```


# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SystemInformation](#system_information)
* [Heartbeat](#heartbeat)
* [ExecutiveSummaries](#executive_summaries)
* [ScheduledReports](#scheduled_reports)

## <a name="system_information"></a>![Class: ](https://apidocs.io/img/class.png "io.dudesolutions.Intelligence.controllers.SystemInformation") SystemInformation

### Get singleton instance

The singleton instance of the ``` SystemInformation ``` class can be accessed from the API Client.

```java
SystemInformation systemInformation = client.getSystemInformation();
```

### <a name="get_system_information_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.SystemInformation.getSystemInformationAsync") getSystemInformationAsync

> TODO: Add a method description


```java
void getSystemInformationAsync(final APICallBack<SystemInformationModel> callBack)
```

#### Example Usage

```java
// Invoking the API call with sample inputs
systemInformation.getSystemInformationAsync(new APICallBack<SystemInformationModel>() {
    public void onSuccess(HttpContext context, SystemInformationModel response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```


[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat"></a>![Class: ](https://apidocs.io/img/class.png "io.dudesolutions.Intelligence.controllers.Heartbeat") Heartbeat

### Get singleton instance

The singleton instance of the ``` Heartbeat ``` class can be accessed from the API Client.

```java
Heartbeat heartbeat = client.getHeartbeat();
```

### <a name="get_heartbeat_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.Heartbeat.getHeartbeatAsync") getHeartbeatAsync

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.


```java
void getHeartbeatAsync(final APICallBack<HeartbeatModel> callBack)
```

#### Example Usage

```java
// Invoking the API call with sample inputs
heartbeat.getHeartbeatAsync(new APICallBack<HeartbeatModel>() {
    public void onSuccess(HttpContext context, HeartbeatModel response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
});

```


[Back to List of Controllers](#list_of_controllers)

## <a name="executive_summaries"></a>![Class: ](https://apidocs.io/img/class.png "io.dudesolutions.Intelligence.controllers.ExecutiveSummaries") ExecutiveSummaries

### Get singleton instance

The singleton instance of the ``` ExecutiveSummaries ``` class can be accessed from the API Client.

```java
ExecutiveSummaries executiveSummaries = client.getExecutiveSummaries();
```

### <a name="get_summary_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.ExecutiveSummaries.getSummaryCollectionAsync") getSummaryCollectionAsync

> TODO: Add a method description


```java
void getSummaryCollectionAsync(
        final GetSummaryCollectionInput input,
        final APICallBack<GetSummaryCollectionResponseModel> callBack)
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

```java
GetSummaryCollectionInput collect = new GetSummaryCollectionInput();

int accountId = 1011;
collect.setAccountId(accountId);

Integer page = 1;
collect.setPage(page);

Integer pagesize = 1000;
collect.setPagesize(pagesize);

String orderby = "Name asc";
collect.setOrderby(orderby);

String type = "\"Event\"";
collect.setType(type);

// Invoking the API call with sample inputs
executiveSummaries.getSummaryCollectionAsync(collect, new APICallBack<GetSummaryCollectionResponseModel>() {
    public void onSuccess(HttpContext context, GetSummaryCollectionResponseModel response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
}
);

```


### <a name="post_summary_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.ExecutiveSummaries.postSummaryCollectionAsync") postSummaryCollectionAsync

> TODO: Add a method description


```java
void postSummaryCollectionAsync(
        final PostSummaryCollectionInput input,
        final APICallBack<ExecutiveSummaryDataModel> callBack)
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

```java
try {
PostSummaryCollectionInput collect = new PostSummaryCollectionInput();

    int accountId = 135;
collect.setAccountId(accountId);

    ExecutiveSummaryDataModel body = new ExecutiveSummaryDataModel();
collect.setBody(body);

    Integer page = 135;
collect.setPage(page);

    Integer pagesize = 135;
collect.setPagesize(pagesize);

    String orderby = "orderby";
collect.setOrderby(orderby);

    String type = "type";
collect.setType(type);

    // Invoking the API call with sample inputs
    executiveSummaries.postSummaryCollectionAsync(collect, new APICallBack<ExecutiveSummaryDataModel>() {
        public void onSuccess(HttpContext context, ExecutiveSummaryDataModel response) {
            // TODO success callback handler
        }
        public void onFailure(HttpContext context, Throwable error) {
            // TODO failure callback handler
        }
    }
);
} catch(JsonProcessingException e) {
    // TODO Auto-generated catch block
    e.printStackTrace();
}
```


### <a name="get_summary_collection_detail_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.ExecutiveSummaries.getSummaryCollectionDetailAsync") getSummaryCollectionDetailAsync

> TODO: Add a method description


```java
void getSummaryCollectionDetailAsync(
        final GetSummaryCollectionDetailInput input,
        final APICallBack<ExecutiveSummaryDataModel> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |


#### Example Usage

```java
GetSummaryCollectionDetailInput collect = new GetSummaryCollectionDetailInput();

int accountId = 1011;
collect.setAccountId(accountId);

int id = 1011;
collect.setId(id);

// Invoking the API call with sample inputs
executiveSummaries.getSummaryCollectionDetailAsync(collect, new APICallBack<ExecutiveSummaryDataModel>() {
    public void onSuccess(HttpContext context, ExecutiveSummaryDataModel response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
}
);

```


### <a name="delete_summary_collection_detail_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.ExecutiveSummaries.deleteSummaryCollectionDetailAsync") deleteSummaryCollectionDetailAsync

> TODO: Add a method description


```java
void deleteSummaryCollectionDetailAsync(
        final DeleteSummaryCollectionDetailInput input,
        final APICallBack<Object> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |


#### Example Usage

```java
DeleteSummaryCollectionDetailInput collect = new DeleteSummaryCollectionDetailInput();

int accountId = 1011;
collect.setAccountId(accountId);

int id = 1011;
collect.setId(id);

// Invoking the API call with sample inputs
executiveSummaries.deleteSummaryCollectionDetailAsync(collect, new APICallBack<void>() {
    public void onSuccess(HttpContext context, void response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
}
);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="scheduled_reports"></a>![Class: ](https://apidocs.io/img/class.png "io.dudesolutions.Intelligence.controllers.ScheduledReports") ScheduledReports

### Get singleton instance

The singleton instance of the ``` ScheduledReports ``` class can be accessed from the API Client.

```java
ScheduledReports scheduledReports = client.getScheduledReports();
```

### <a name="get_scheduled_reports_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.ScheduledReports.getScheduledReportsCollectionAsync") getScheduledReportsCollectionAsync

> TODO: Add a method description


```java
void getScheduledReportsCollectionAsync(
        final GetScheduledReportsCollectionInput input,
        final APICallBack<GetScheduledReportsCollectionResponseModel> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |


#### Example Usage

```java
GetScheduledReportsCollectionInput collect = new GetScheduledReportsCollectionInput();

int accountId = 1011;
collect.setAccountId(accountId);

Integer page = 1;
collect.setPage(page);

Integer pagesize = 1000;
collect.setPagesize(pagesize);

String orderby = "Name asc";
collect.setOrderby(orderby);

// Invoking the API call with sample inputs
scheduledReports.getScheduledReportsCollectionAsync(collect, new APICallBack<GetScheduledReportsCollectionResponseModel>() {
    public void onSuccess(HttpContext context, GetScheduledReportsCollectionResponseModel response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
}
);

```


### <a name="post_scheduled_reports_collection_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.ScheduledReports.postScheduledReportsCollectionAsync") postScheduledReportsCollectionAsync

> TODO: Add a method description


```java
void postScheduledReportsCollectionAsync(
        final PostScheduledReportsCollectionInput input,
        final APICallBack<ScheduledReportDataModel> callBack)
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

```java
try {
PostScheduledReportsCollectionInput collect = new PostScheduledReportsCollectionInput();

    int accountId = 135;
collect.setAccountId(accountId);

    ScheduledReportDataModel body = new ScheduledReportDataModel();
collect.setBody(body);

    Integer page = 135;
collect.setPage(page);

    Integer pagesize = 135;
collect.setPagesize(pagesize);

    String orderby = "orderby";
collect.setOrderby(orderby);

    // Invoking the API call with sample inputs
    scheduledReports.postScheduledReportsCollectionAsync(collect, new APICallBack<ScheduledReportDataModel>() {
        public void onSuccess(HttpContext context, ScheduledReportDataModel response) {
            // TODO success callback handler
        }
        public void onFailure(HttpContext context, Throwable error) {
            // TODO failure callback handler
        }
    }
);
} catch(JsonProcessingException e) {
    // TODO Auto-generated catch block
    e.printStackTrace();
}
```


### <a name="get_scheduled_reports_collection_detail_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.ScheduledReports.getScheduledReportsCollectionDetailAsync") getScheduledReportsCollectionDetailAsync

> TODO: Add a method description


```java
void getScheduledReportsCollectionDetailAsync(
        final GetScheduledReportsCollectionDetailInput input,
        final APICallBack<ScheduledReportDataModel> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |


#### Example Usage

```java
GetScheduledReportsCollectionDetailInput collect = new GetScheduledReportsCollectionDetailInput();

int accountId = 1011;
collect.setAccountId(accountId);

int id = 1011;
collect.setId(id);

// Invoking the API call with sample inputs
scheduledReports.getScheduledReportsCollectionDetailAsync(collect, new APICallBack<ScheduledReportDataModel>() {
    public void onSuccess(HttpContext context, ScheduledReportDataModel response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
}
);

```


### <a name="delete_scheduled_reports_collection_detail_async"></a>![Method: ](https://apidocs.io/img/method.png "io.dudesolutions.Intelligence.controllers.ScheduledReports.deleteScheduledReportsCollectionDetailAsync") deleteScheduledReportsCollectionDetailAsync

> TODO: Add a method description


```java
void deleteScheduledReportsCollectionDetailAsync(
        final DeleteScheduledReportsCollectionDetailInput input,
        final APICallBack<Object> callBack)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |


#### Example Usage

```java
DeleteScheduledReportsCollectionDetailInput collect = new DeleteScheduledReportsCollectionDetailInput();

int accountId = 1011;
collect.setAccountId(accountId);

int id = 1011;
collect.setId(id);

// Invoking the API call with sample inputs
scheduledReports.deleteScheduledReportsCollectionDetailAsync(collect, new APICallBack<void>() {
    public void onSuccess(HttpContext context, void response) {
        // TODO success callback handler
    }
    public void onFailure(HttpContext context, Throwable error) {
        // TODO failure callback handler
    }
}
);

```


[Back to List of Controllers](#list_of_controllers)



