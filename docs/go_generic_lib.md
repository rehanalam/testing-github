# Getting started

TODO: Add a description

## How to Build


* In order to successfully build and run your SDK files, you are required to have the following setup in your system:
    * **Go**  (Visit [https://golang.org/doc/install](https://golang.org/doc/install) for more details on how to install Go)
    * **Java VM** Version 8 or later
    * **Eclipse 4.6 (Neon)** or later ([http://www.eclipse.org/neon/](http://www.eclipse.org/neon/))
    * **GoClipse** setup within above installed Eclipse (Follow the instructions at [this link](https://github.com/GoClipse/goclipse/blob/latest/documentation/Installation.md#instructions) to setup GoClipse)
* Ensure that ```GOPATH``` environment variable is set in the system variables. If not, set it to your workspace directory where you will be adding your Go projects.
* The generated code uses unirest-go http library. Therefore, you will need internet access to resolve this dependency. If Go is properly installed and configured, run the following command to pull the dependency:

```Go
go get github.com/apimatic/unirest-go
```

This will install unirest-go in the ```GOPATH``` you specified in the system variables.

Now follow the steps mentioned below to build your SDK:

1. Open eclipse in the Go language perspective and click on the ```Import``` option in ```File``` menu.

![Importing SDK into Eclipse - Step 1](https://apidocs.io/illustration/go?step=import0)

2. Select ```General -> Existing Projects into Workspace``` option from the tree list.

![Importing SDK into Eclipse - Step 2](https://apidocs.io/illustration/go?step=import1)

3. In ```Select root directory```, provide path to the unzipped archive for the generated code. Once the path is set and the Project becomes visible under ```Projects``` click ```Finish```

![Importing SDK into Eclipse - Step 3](https://apidocs.io/illustration/go?step=import2&workspaceFolder=Dude%20Intelligence%20Api-GoLang&projectName=dudeintelligenceapi_lib)

4. The Go library will be imported and its files will be visible in the Project Explorer

![Importing SDK into Eclipse - Step 4](https://apidocs.io/illustration/go?step=import3&projectName=dudeintelligenceapi_lib)

## How to Use

The following section explains how to use the DudeintelligenceapiLib library in a new project.

### 1. Add a new Test Project

Create a new project in Eclipse by ```File``` -> ```New``` -> ```Go Project```

![Add a new project in Eclipse](https://apidocs.io/illustration/go?step=createNewProject0)

Name the Project as ```Test``` and click ```Finish```

![Create a new Maven Project - Step 1](https://apidocs.io/illustration/go?step=createNewProject1)

Create a new directory in the ```src``` directory of this project

![Create a new Maven Project - Step 2](https://apidocs.io/illustration/go?step=createNewProject2&projectName=dudeintelligenceapi_lib)

Name it ```test.com```

![Create a new Maven Project - Step 3](https://apidocs.io/illustration/go?step=createNewProject3&projectName=dudeintelligenceapi_lib)

Now create a new file inside ```src/test.com```

![Create a new Maven Project - Step 4](https://apidocs.io/illustration/go?step=createNewProject4&projectName=dudeintelligenceapi_lib)

Name it ```testsdk.go```

![Create a new Maven Project - Step 5](https://apidocs.io/illustration/go?step=createNewProject5&projectName=dudeintelligenceapi_lib)

In this Go file, you can start adding code to initialize the client library. Sample code to initialize the client library and using its methods is given in the subsequent sections.

### 2. Configure the Test Project

You need to import your generated library in this project in order to make use of its functions. In order to import the library, you can add its path in the ```GOPATH``` for this project. Follow the below steps:

Right click on the project name and click on ```Properties```

![Adding dependency to the client library - Step 1](https://apidocs.io/illustration/go?step=testProject0&projectName=dudeintelligenceapi_lib)

Choose ```Go Compiler``` from the side menu. Check ```Use project specific settings``` and uncheck ```Use same value as the GOPATH environment variable.```. By default, the GOPATH value from the environment variables will be visible in ```Eclipse GOPATH```. Do not remove this as this points to the unirest dependency.

![Adding dependency to the client library - Step 2](https://apidocs.io/illustration/go?step=testProject1)

Append the library path to this GOPATH

![Adding dependency to the client library - Step 3](https://apidocs.io/illustration/go?step=testProject2&workspaceFolder=Dude%20Intelligence%20Api-GoLang)

Once the path is appended, click on ```OK```

### 3. Build the Test Project

Right click on the project name and click on ```Build Project```

![Build Project](https://apidocs.io/illustration/go?step=buildProject&projectName=dudeintelligenceapi_lib)

### 4. Run the Test Project

If the build is successful, right click on your Go file and click on ```Run As``` -> ```Go Application```

![Run Project](https://apidocs.io/illustration/go?step=runProject&projectName=dudeintelligenceapi_lib)

## Initialization

### Authentication
In order to setup authentication of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |


To configure these for your generated code, open the file "Configuration.go" and edit it's contents.


# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [systeminformation_pkg](#systeminformation_pkg)
* [heartbeat_pkg](#heartbeat_pkg)
* [executivesummaries_pkg](#executivesummaries_pkg)
* [scheduledreports_pkg](#scheduledreports_pkg)

## <a name="systeminformation_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".systeminformation_pkg") systeminformation_pkg

### Get instance

Factory for the ``` SYSTEMINFORMATION ``` interface can be accessed from the package systeminformation_pkg.

```go
systemInformation := systeminformation_pkg.NewSYSTEMINFORMATION()
```

### <a name="get_system_information"></a>![Method: ](https://apidocs.io/img/method.png ".systeminformation_pkg.GetSystemInformation") GetSystemInformation

> TODO: Add a method description


```go
func (me *SYSTEMINFORMATION_IMPL) GetSystemInformation()(*models_pkg.SystemInformationModel,error)
```

#### Example Usage

```go

var result *models_pkg.SystemInformationModel
result,_ = systemInformation.GetSystemInformation()

```


[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".heartbeat_pkg") heartbeat_pkg

### Get instance

Factory for the ``` HEARTBEAT ``` interface can be accessed from the package heartbeat_pkg.

```go
heartbeat := heartbeat_pkg.NewHEARTBEAT()
```

### <a name="get_heartbeat"></a>![Method: ](https://apidocs.io/img/method.png ".heartbeat_pkg.GetHeartbeat") GetHeartbeat

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.


```go
func (me *HEARTBEAT_IMPL) GetHeartbeat()(*models_pkg.HeartbeatModel,error)
```

#### Example Usage

```go

var result *models_pkg.HeartbeatModel
result,_ = heartbeat.GetHeartbeat()

```


[Back to List of Controllers](#list_of_controllers)

## <a name="executivesummaries_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".executivesummaries_pkg") executivesummaries_pkg

### Get instance

Factory for the ``` EXECUTIVESUMMARIES ``` interface can be accessed from the package executivesummaries_pkg.

```go
executiveSummaries := executivesummaries_pkg.NewEXECUTIVESUMMARIES()
```

### <a name="get_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".executivesummaries_pkg.GetSummaryCollection") GetSummaryCollection

> TODO: Add a method description


```go
func (me *EXECUTIVESUMMARIES_IMPL) GetSummaryCollection(input *GetSummaryCollectionInput)(*models_pkg.GetSummaryCollectionResponseModel,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| mtype |  ``` Optional ```  | The type of records to filter by. |


#### Example Usage

```go
collect := new (executivesummaries_pkg.GetSummaryCollectionInput)

accountId,_ := strconv.ParseInt("1011", 10, 8)
collect.AccountId = accountId

page,_ := strconv.ParseInt("1", 10, 8)
collect.Page = page

pagesize,_ := strconv.ParseInt("1000", 10, 8)
collect.Pagesize = pagesize

orderby := "Name asc"
collect.Orderby = orderby

mtype := "\"Event\""
collect.Mtype = mtype


var result *models_pkg.GetSummaryCollectionResponseModel
result,_ = executiveSummaries.GetSummaryCollection(collect)

```


### <a name="post_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".executivesummaries_pkg.PostSummaryCollection") PostSummaryCollection

> TODO: Add a method description


```go
func (me *EXECUTIVESUMMARIES_IMPL) PostSummaryCollection(input *PostSummaryCollectionInput)(*models_pkg.ExecutiveSummaryDataModel,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| body |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| mtype |  ``` Optional ```  | The type of records to filter by. |


#### Example Usage

```go
collect := new (executivesummaries_pkg.PostSummaryCollectionInput)

accountId,_ := strconv.ParseInt("8", 10, 8)
collect.AccountId = accountId

var body *models_pkg.ExecutiveSummaryDataModel
collect.Body = body

page,_ := strconv.ParseInt("8", 10, 8)
collect.Page = page

pagesize,_ := strconv.ParseInt("8", 10, 8)
collect.Pagesize = pagesize

orderby := "orderby"
collect.Orderby = orderby

mtype := "type"
collect.Mtype = mtype


var result *models_pkg.ExecutiveSummaryDataModel
result,_ = executiveSummaries.PostSummaryCollection(collect)

```


### <a name="get_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".executivesummaries_pkg.GetSummaryCollectionDetail") GetSummaryCollectionDetail

> TODO: Add a method description


```go
func (me *EXECUTIVESUMMARIES_IMPL) GetSummaryCollectionDetail(input *GetSummaryCollectionDetailInput)(*models_pkg.ExecutiveSummaryDataModel,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |


#### Example Usage

```go
collect := new (executivesummaries_pkg.GetSummaryCollectionDetailInput)

accountId,_ := strconv.ParseInt("1011", 10, 8)
collect.AccountId = accountId

id,_ := strconv.ParseInt("1011", 10, 8)
collect.Id = id


var result *models_pkg.ExecutiveSummaryDataModel
result,_ = executiveSummaries.GetSummaryCollectionDetail(collect)

```


### <a name="delete_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".executivesummaries_pkg.DeleteSummaryCollectionDetail") DeleteSummaryCollectionDetail

> TODO: Add a method description


```go
func (me *EXECUTIVESUMMARIES_IMPL) DeleteSummaryCollectionDetail(input *DeleteSummaryCollectionDetailInput)(,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |


#### Example Usage

```go
collect := new (executivesummaries_pkg.DeleteSummaryCollectionDetailInput)

accountId,_ := strconv.ParseInt("1011", 10, 8)
collect.AccountId = accountId

id,_ := strconv.ParseInt("1011", 10, 8)
collect.Id = id


var result 
result,_ = executiveSummaries.DeleteSummaryCollectionDetail(collect)

```


[Back to List of Controllers](#list_of_controllers)

## <a name="scheduledreports_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".scheduledreports_pkg") scheduledreports_pkg

### Get instance

Factory for the ``` SCHEDULEDREPORTS ``` interface can be accessed from the package scheduledreports_pkg.

```go
scheduledReports := scheduledreports_pkg.NewSCHEDULEDREPORTS()
```

### <a name="get_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".scheduledreports_pkg.GetScheduledReportsCollection") GetScheduledReportsCollection

> TODO: Add a method description


```go
func (me *SCHEDULEDREPORTS_IMPL) GetScheduledReportsCollection(input *GetScheduledReportsCollectionInput)(*models_pkg.GetScheduledReportsCollectionResponseModel,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |


#### Example Usage

```go
collect := new (scheduledreports_pkg.GetScheduledReportsCollectionInput)

accountId,_ := strconv.ParseInt("1011", 10, 8)
collect.AccountId = accountId

page,_ := strconv.ParseInt("1", 10, 8)
collect.Page = page

pagesize,_ := strconv.ParseInt("1000", 10, 8)
collect.Pagesize = pagesize

orderby := "Name asc"
collect.Orderby = orderby


var result *models_pkg.GetScheduledReportsCollectionResponseModel
result,_ = scheduledReports.GetScheduledReportsCollection(collect)

```


### <a name="post_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".scheduledreports_pkg.PostScheduledReportsCollection") PostScheduledReportsCollection

> TODO: Add a method description


```go
func (me *SCHEDULEDREPORTS_IMPL) PostScheduledReportsCollection(input *PostScheduledReportsCollectionInput)(*models_pkg.ScheduledReportDataModel,error)
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

```go
collect := new (scheduledreports_pkg.PostScheduledReportsCollectionInput)

accountId,_ := strconv.ParseInt("8", 10, 8)
collect.AccountId = accountId

var body *models_pkg.ScheduledReportDataModel
collect.Body = body

page,_ := strconv.ParseInt("8", 10, 8)
collect.Page = page

pagesize,_ := strconv.ParseInt("8", 10, 8)
collect.Pagesize = pagesize

orderby := "orderby"
collect.Orderby = orderby


var result *models_pkg.ScheduledReportDataModel
result,_ = scheduledReports.PostScheduledReportsCollection(collect)

```


### <a name="get_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".scheduledreports_pkg.GetScheduledReportsCollectionDetail") GetScheduledReportsCollectionDetail

> TODO: Add a method description


```go
func (me *SCHEDULEDREPORTS_IMPL) GetScheduledReportsCollectionDetail(input *GetScheduledReportsCollectionDetailInput)(*models_pkg.ScheduledReportDataModel,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |


#### Example Usage

```go
collect := new (scheduledreports_pkg.GetScheduledReportsCollectionDetailInput)

accountId,_ := strconv.ParseInt("1011", 10, 8)
collect.AccountId = accountId

id,_ := strconv.ParseInt("1011", 10, 8)
collect.Id = id


var result *models_pkg.ScheduledReportDataModel
result,_ = scheduledReports.GetScheduledReportsCollectionDetail(collect)

```


### <a name="delete_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".scheduledreports_pkg.DeleteScheduledReportsCollectionDetail") DeleteScheduledReportsCollectionDetail

> TODO: Add a method description


```go
func (me *SCHEDULEDREPORTS_IMPL) DeleteScheduledReportsCollectionDetail(input *DeleteScheduledReportsCollectionDetailInput)(,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |


#### Example Usage

```go
collect := new (scheduledreports_pkg.DeleteScheduledReportsCollectionDetailInput)

accountId,_ := strconv.ParseInt("1011", 10, 8)
collect.AccountId = accountId

id,_ := strconv.ParseInt("1011", 10, 8)
collect.Id = id


var result 
result,_ = scheduledReports.DeleteScheduledReportsCollectionDetail(collect)

```


[Back to List of Controllers](#list_of_controllers)



