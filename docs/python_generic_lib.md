# Getting started

TODO: Add a description

## How to Build


You must have Python 2 >=2.7.9 or Python 3 >=3.4 installed on your system to install and run this SDK. This SDK package depends on other Python packages like nose, jsonpickle etc. 
These dependencies are defined in the ```requirements.txt``` file that comes with the SDK.
To resolve these dependencies, you can use the PIP Dependency manager. Install it by following steps at [https://pip.pypa.io/en/stable/installing/](https://pip.pypa.io/en/stable/installing/).

Python and PIP executables should be defined in your PATH. Open command prompt and type ```pip --version```.
This should display the version of the PIP Dependency Manager installed if your installation was successful and the paths are properly defined.

* Using command line, navigate to the directory containing the generated files (including ```requirements.txt```) for the SDK.
* Run the command ```pip install -r requirements.txt```. This should install all the required dependencies.

![Building SDK - Step 1](https://apidocs.io/illustration/python?step=installDependencies&workspaceFolder=Dude%20Intelligence%20Api-Python)


## How to Use

The following section explains how to use the Dudeintelligenceapi SDK package in a new project.

### 1. Open Project in an IDE

Open up a Python IDE like PyCharm. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

![Open project in PyCharm - Step 1](https://apidocs.io/illustration/python?step=pyCharm)

Click on ```Open``` in PyCharm to browse to your generated SDK directory and then click ```OK```.

![Open project in PyCharm - Step 2](https://apidocs.io/illustration/python?step=openProject0&workspaceFolder=Dude%20Intelligence%20Api-Python)     

The project files will be displayed in the side bar as follows:

![Open project in PyCharm - Step 3](https://apidocs.io/illustration/python?step=openProject1&workspaceFolder=Dude%20Intelligence%20Api-Python&projectName=dudeintelligenceapi)     

### 2. Add a new Test Project

Create a new directory by right clicking on the solution name as shown below:

![Add a new project in PyCharm - Step 1](https://apidocs.io/illustration/python?step=createDirectory&workspaceFolder=Dude%20Intelligence%20Api-Python&projectName=dudeintelligenceapi)

Name the directory as "test"

![Add a new project in PyCharm - Step 2](https://apidocs.io/illustration/python?step=nameDirectory)
   
Add a python file to this project with the name "testsdk"

![Add a new project in PyCharm - Step 3](https://apidocs.io/illustration/python?step=createFile&workspaceFolder=Dude%20Intelligence%20Api-Python&projectName=dudeintelligenceapi)

Name it "testsdk"

![Add a new project in PyCharm - Step 4](https://apidocs.io/illustration/python?step=nameFile)

In your python file you will be required to import the generated python library using the following code lines

```Python
from dudeintelligenceapi.dudeintelligenceapi_client import DudeintelligenceapiClient
```

![Add a new project in PyCharm - Step 4](https://apidocs.io/illustration/python?step=projectFiles&workspaceFolder=Dude%20Intelligence%20Api-Python&libraryName=dudeintelligenceapi.dudeintelligenceapi_client&projectName=dudeintelligenceapi)

After this you can write code to instantiate an API client object, get a controller object and  make API calls. Sample code is given in the subsequent sections.

### 3. Run the Test Project

To run the file within your test project, right click on your Python file inside your Test project and click on ```Run```

![Run Test Project - Step 1](https://apidocs.io/illustration/python?step=runProject&workspaceFolder=Dude%20Intelligence%20Api-Python&libraryName=dudeintelligenceapi.dudeintelligenceapi_client&projectName=dudeintelligenceapi)


## How to Test

You can test the generated SDK and the server with automatically generated test
cases. unittest is used as the testing framework and nose is used as the test
runner. You can run the tests as follows:

  1. From terminal/cmd navigate to the root directory of the SDK.
  2. Invoke 'pip install -r test-requirements.txt'
  3. Invoke 'nosetests'

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| o_auth_access_token | OAuth 2.0 Access Token |



API client can be initialized as following.

```python
# Configuration parameters and credentials
o_auth_access_token = 'o_auth_access_token' # OAuth 2.0 Access Token

client = DudeintelligenceapiClient(o_auth_access_token)
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SystemInformation](#system_information)
* [Heartbeat](#heartbeat)
* [ExecutiveSummaries](#executive_summaries)
* [ScheduledReports](#scheduled_reports)

## <a name="system_information"></a>![Class: ](https://apidocs.io/img/class.png ".SystemInformation") SystemInformation

### Get controller instance

An instance of the ``` SystemInformation ``` class can be accessed from the API Client.

```python
 system_information_client = client.system_information
```

### <a name="get_system_information"></a>![Method: ](https://apidocs.io/img/method.png ".SystemInformation.get_system_information") get_system_information

> TODO: Add a method description

```python
def get_system_information(self)
```

#### Example Usage

```python

result = system_information_client.get_system_information()

```


[Back to List of Controllers](#list_of_controllers)

## <a name="heartbeat"></a>![Class: ](https://apidocs.io/img/class.png ".Heartbeat") Heartbeat

### Get controller instance

An instance of the ``` Heartbeat ``` class can be accessed from the API Client.

```python
 heartbeat_client = client.heartbeat
```

### <a name="get_heartbeat"></a>![Method: ](https://apidocs.io/img/method.png ".Heartbeat.get_heartbeat") get_heartbeat

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.

```python
def get_heartbeat(self)
```

#### Example Usage

```python

result = heartbeat_client.get_heartbeat()

```


[Back to List of Controllers](#list_of_controllers)

## <a name="executive_summaries"></a>![Class: ](https://apidocs.io/img/class.png ".ExecutiveSummaries") ExecutiveSummaries

### Get controller instance

An instance of the ``` ExecutiveSummaries ``` class can be accessed from the API Client.

```python
 executive_summaries_client = client.executive_summaries
```

### <a name="get_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.get_summary_collection") get_summary_collection

> TODO: Add a method description

```python
def get_summary_collection(self,
                               options=dict())
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

```python
collect = {}

account_id = 1011
collect['account_id'] = account_id

page = 1
collect['page'] = page

pagesize = 1000
collect['pagesize'] = pagesize

orderby = 'Name asc'
collect['orderby'] = orderby

mtype = '"Event"'
collect['mtype'] = mtype


result = executive_summaries_client.get_summary_collection(collect)

```


### <a name="post_summary_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.post_summary_collection") post_summary_collection

> TODO: Add a method description

```python
def post_summary_collection(self,
                                options=dict())
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

```python
collect = {}

account_id = 121
collect['account_id'] = account_id

body = ExecutiveSummaryDataModel()
collect['body'] = body

page = 121
collect['page'] = page

pagesize = 121
collect['pagesize'] = pagesize

orderby = 'orderby'
collect['orderby'] = orderby

mtype = 'type'
collect['mtype'] = mtype


result = executive_summaries_client.post_summary_collection(collect)

```


### <a name="get_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.get_summary_collection_detail") get_summary_collection_detail

> TODO: Add a method description

```python
def get_summary_collection_detail(self,
                                      options=dict())
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |



#### Example Usage

```python
collect = {}

account_id = 1011
collect['account_id'] = account_id

id = 1011
collect['id'] = id


result = executive_summaries_client.get_summary_collection_detail(collect)

```


### <a name="delete_summary_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ExecutiveSummaries.delete_summary_collection_detail") delete_summary_collection_detail

> TODO: Add a method description

```python
def delete_summary_collection_detail(self,
                                         options=dict())
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the execute summary to be retrieved. |



#### Example Usage

```python
collect = {}

account_id = 1011
collect['account_id'] = account_id

id = 1011
collect['id'] = id


executive_summaries_client.delete_summary_collection_detail(collect)

```


[Back to List of Controllers](#list_of_controllers)

## <a name="scheduled_reports"></a>![Class: ](https://apidocs.io/img/class.png ".ScheduledReports") ScheduledReports

### Get controller instance

An instance of the ``` ScheduledReports ``` class can be accessed from the API Client.

```python
 scheduled_reports_client = client.scheduled_reports
```

### <a name="get_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.get_scheduled_reports_collection") get_scheduled_reports_collection

> TODO: Add a method description

```python
def get_scheduled_reports_collection(self,
                                         options=dict())
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| orderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |



#### Example Usage

```python
collect = {}

account_id = 1011
collect['account_id'] = account_id

page = 1
collect['page'] = page

pagesize = 1000
collect['pagesize'] = pagesize

orderby = 'Name asc'
collect['orderby'] = orderby


result = scheduled_reports_client.get_scheduled_reports_collection(collect)

```


### <a name="post_scheduled_reports_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.post_scheduled_reports_collection") post_scheduled_reports_collection

> TODO: Add a method description

```python
def post_scheduled_reports_collection(self,
                                          options=dict())
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

```python
collect = {}

account_id = 80
collect['account_id'] = account_id

body = ScheduledReportDataModel()
collect['body'] = body

page = 80
collect['page'] = page

pagesize = 80
collect['pagesize'] = pagesize

orderby = 'orderby'
collect['orderby'] = orderby


result = scheduled_reports_client.post_scheduled_reports_collection(collect)

```


### <a name="get_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.get_scheduled_reports_collection_detail") get_scheduled_reports_collection_detail

> TODO: Add a method description

```python
def get_scheduled_reports_collection_detail(self,
                                                options=dict())
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |



#### Example Usage

```python
collect = {}

account_id = 1011
collect['account_id'] = account_id

id = 1011
collect['id'] = id


result = scheduled_reports_client.get_scheduled_reports_collection_detail(collect)

```


### <a name="delete_scheduled_reports_collection_detail"></a>![Method: ](https://apidocs.io/img/method.png ".ScheduledReports.delete_scheduled_reports_collection_detail") delete_scheduled_reports_collection_detail

> TODO: Add a method description

```python
def delete_scheduled_reports_collection_detail(self,
                                                   options=dict())
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | Id of the scheduled report to be retrieved. |



#### Example Usage

```python
collect = {}

account_id = 1011
collect['account_id'] = account_id

id = 1011
collect['id'] = id


scheduled_reports_client.delete_scheduled_reports_collection_detail(collect)

```


[Back to List of Controllers](#list_of_controllers)



