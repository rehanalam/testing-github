# Getting started

TODO: Add a description

## How to Build

This client library is a Ruby gem which can be compiled and used in your Ruby and Ruby on Rails project. This library requires a few gems from the RubyGems repository.

1. Open the command line interface or the terminal and navigate to the folder containing the source code.
2. Run ``` gem build dude_intelligence_api.gemspec ``` to build the gem.
3. Once built, the gem can be installed on the current work environment using ``` gem install dude_intelligence_api-1.0.0.gem ```

![Building Gem](https://apidocs.io/illustration/ruby?step=buildSDK&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=Dude%20Intelligence%20Api-Ruby&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

## How to Use

The following section explains how to use the DudeIntelligenceApi Ruby Gem in a new Rails project using RubyMine&trade;. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

### 1. Starting a new project

Close any existing projects in RubyMine&trade; by selecting ``` File -> Close Project ```. Next, click on ``` Create New Project ``` to create a new project from scratch.

![Create a new project in RubyMine](https://apidocs.io/illustration/ruby?step=createNewProject0&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

Next, provide ``` TestApp ``` as the project name, choose ``` Rails Application ``` as the project type, and click ``` OK ```.

![Create a new Rails Application in RubyMine - step 1](https://apidocs.io/illustration/ruby?step=createNewProject1&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

In the next dialog make sure that correct *Ruby SDK* is being used (minimum 2.0.0) and click ``` OK ```.

![Create a new Rails Application in RubyMine - step 2](https://apidocs.io/illustration/ruby?step=createNewProject2&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

This will create a new Rails Application project with an existing set of files and folder.

### 2. Add reference of the gem

In order to use the DudeIntelligenceApi gem in the new project we must add a gem reference. Locate the ```Gemfile``` in the *Project Explorer* window under the ``` TestApp ``` project node. The file contains references to all gems being used in the project. Here, add the reference to the library gem by adding the following line: ``` gem 'dude_intelligence_api', '~> 1.0.0' ```

![Add references of the Gemfile](https://apidocs.io/illustration/ruby?step=addReference&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

### 3. Adding a new Rails Controller

Once the ``` TestApp ``` project is created, a folder named ``` controllers ``` will be visible in the *Project Explorer* under the following path: ``` TestApp > app > controllers ```. Right click on this folder and select ``` New -> Run Rails Generator... ```.

![Run Rails Generator on Controllers Folder](https://apidocs.io/illustration/ruby?step=addCode0&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

Selecting the said option will popup a small window where the generator names are displayed. Here, select the ``` controller ``` template.

![Create a new Controller](https://apidocs.io/illustration/ruby?step=addCode1&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

Next, a popup window will ask you for a Controller name and included Actions. For controller name provide ``` Hello ``` and include an action named ``` Index ``` and click ``` OK ```.

![Add a new Controller](https://apidocs.io/illustration/ruby?step=addCode2&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

A new controller class anmed ``` HelloController ``` will be created in a file named ``` hello_controller.rb ``` containing a method named ``` Index ```. In this method, add code for initialization and a sample for its usage.

![Initialize the library](https://apidocs.io/illustration/ruby?step=addCode3&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0)

## How to Test

You can test the generated SDK and the server with automatically generated test
cases as follows:

  1. From terminal/cmd navigate to the root directory of the SDK.
  2. Invoke: `bundle exec rake`

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| o_auth_access_token | OAuth 2.0 Access Token |



API client can be initialized as following.

```ruby
# Configuration parameters and credentials
o_auth_access_token = 'o_auth_access_token' # OAuth 2.0 Access Token

client = DudeIntelligenceApi::DudeIntelligenceApiClient.new(
  o_auth_access_token: o_auth_access_token
)
```

The added initlization code can be debugged by putting a breakpoint in the ``` Index ``` method and running the project in debug mode by selecting ``` Run -> Debug 'Development: TestApp' ```.

![Debug the TestApp](https://apidocs.io/illustration/ruby?step=addCode4&workspaceFolder=Dude%20Intelligence%20Api-Ruby&workspaceName=DudeIntelligenceApi&projectName=dude_intelligence_api&gemName=dude_intelligence_api&gemVer=1.0.0&initLine=client%2520%253D%2520DudeIntelligenceApiClient.new%2528%2527o_auth_access_token%2527%2529)



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SystemInformation](#system_information)
* [Heartbeat](#heartbeat)
* [ExecutiveSummaries](#executive_summaries)
* [ScheduledReports](#scheduled_reports)

## <a name="system_information"></a>![Class: ](https://apidocs.io/img/class.png ".SystemInformation") SystemInformation

### Get singleton instance

The singleton instance of the ``` SystemInformation ``` class can be accessed from the API Client.

```ruby
systemInformation = client.system_information
```

### <a name="get_system_information"></a>![Method: ](https://apidocs.io/img/method.png ".SystemInformation.get_system_information") get_system_information

> TODO: Add a method description


```ruby
def get_system_information; end
```

#### Example Usage

```ruby

result = systemInformation.get_system_information()

```


[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat"></a>![Class: ](https://apidocs.io/img/class.png ".Heartbeat") Heartbeat

### Get singleton instance

The singleton instance of the ``` Heartbeat ``` class can be accessed from the API Client.

```ruby
heartbeat = client.heartbeat
```

### <a name="get_heartbeat"></a>![Method: ](https://apidocs.io/img/method.png ".Heartbeat.get_heartbeat") get_heartbeat

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.


```ruby
def get_heartbeat; end
```

#### Example Usage

```ruby

result = heartbeat.get_heartbeat()

```


[Back to List of Controllers](#list_of_controllers)

## <a name="executive_summaries"></a>![Class: ](https://apidocs.io/img/class.png ".ExecutiveSummaries") ExecutiveSummaries

### Get singleton instance

The singleton instance of the ``` ExecutiveSummaries ``` class can be accessed from the API Client.

```ruby
executiveSummaries = client.executive_summaries
```

### <a name="get_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.get_summary_collection") get_summary_collection

> TODO: Add a method description


```ruby
def get_summary_collection(options = Hash.new); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| account_id |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| type |  ``` Optional ```  | The type of records to filter by. |


#### Example Usage

```ruby
collect = Hash.new

account_id = 1011
collect['account_id'] = account_id

page = 1
collect['page'] = page

pagesize = 1000
collect['pagesize'] = pagesize

orderby = 'Name asc'
collect['orderby'] = orderby

type = '"Event"'
collect['type'] = type


result = executiveSummaries.get_summary_collection(collect)

```


### <a name="post_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.post_summary_collection") post_summary_collection

> TODO: Add a method description


```ruby
def post_summary_collection(options = Hash.new); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| account_id |  ``` Required ```  | ID of the account in the form of an integer |
| body |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| type |  ``` Optional ```  | The type of records to filter by. |


#### Example Usage

```ruby
collect = Hash.new

account_id = 144
collect['account_id'] = account_id

body = ExecutiveSummaryDataModel.new
collect['body'] = body

page = 144
collect['page'] = page

pagesize = 144
collect['pagesize'] = pagesize

orderby = 'orderby'
collect['orderby'] = orderby

type = 'type'
collect['type'] = type


result = executiveSummaries.post_summary_collection(collect)

```


### <a name="get_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.get_summary_collection_detail") get_summary_collection_detail

> TODO: Add a method description


```ruby
def get_summary_collection_detail(options = Hash.new); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| account_id |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |


#### Example Usage

```ruby
collect = Hash.new

account_id = 1011
collect['account_id'] = account_id

id = 1011
collect['id'] = id


result = executiveSummaries.get_summary_collection_detail(collect)

```


### <a name="delete_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.delete_summary_collection_detail") delete_summary_collection_detail

> TODO: Add a method description


```ruby
def delete_summary_collection_detail(options = Hash.new); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| account_id |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |


#### Example Usage

```ruby
collect = Hash.new

account_id = 1011
collect['account_id'] = account_id

id = 1011
collect['id'] = id


executiveSummaries.delete_summary_collection_detail(collect)

```


[Back to List of Controllers](#list_of_controllers)

## <a name="scheduled_reports"></a>![Class: ](https://apidocs.io/img/class.png ".ScheduledReports") ScheduledReports

### Get singleton instance

The singleton instance of the ``` ScheduledReports ``` class can be accessed from the API Client.

```ruby
scheduledReports = client.scheduled_reports
```

### <a name="get_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.get_scheduled_reports_collection") get_scheduled_reports_collection

> TODO: Add a method description


```ruby
def get_scheduled_reports_collection(options = Hash.new); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| account_id |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |


#### Example Usage

```ruby
collect = Hash.new

account_id = 1011
collect['account_id'] = account_id

page = 1
collect['page'] = page

pagesize = 1000
collect['pagesize'] = pagesize

orderby = 'Name asc'
collect['orderby'] = orderby


result = scheduledReports.get_scheduled_reports_collection(collect)

```


### <a name="post_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.post_scheduled_reports_collection") post_scheduled_reports_collection

> TODO: Add a method description


```ruby
def post_scheduled_reports_collection(options = Hash.new); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| account_id |  ``` Required ```  | ID of the account in the form of an integer |
| body |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |


#### Example Usage

```ruby
collect = Hash.new

account_id = 235
collect['account_id'] = account_id

body = ScheduledReportDataModel.new
collect['body'] = body

page = 235
collect['page'] = page

pagesize = 235
collect['pagesize'] = pagesize

orderby = 'orderby'
collect['orderby'] = orderby


result = scheduledReports.post_scheduled_reports_collection(collect)

```


### <a name="get_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.get_scheduled_reports_collection_detail") get_scheduled_reports_collection_detail

> TODO: Add a method description


```ruby
def get_scheduled_reports_collection_detail(options = Hash.new); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| account_id |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |


#### Example Usage

```ruby
collect = Hash.new

account_id = 1011
collect['account_id'] = account_id

id = 1011
collect['id'] = id


result = scheduledReports.get_scheduled_reports_collection_detail(collect)

```


### <a name="delete_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.delete_scheduled_reports_collection_detail") delete_scheduled_reports_collection_detail

> TODO: Add a method description


```ruby
def delete_scheduled_reports_collection_detail(options = Hash.new); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| account_id |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |


#### Example Usage

```ruby
collect = Hash.new

account_id = 1011
collect['account_id'] = account_id

id = 1011
collect['id'] = id


scheduledReports.delete_scheduled_reports_collection_detail(collect)

```


[Back to List of Controllers](#list_of_controllers)



