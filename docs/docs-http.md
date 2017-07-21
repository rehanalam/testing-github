# 

TODO: Add a description



## Base URL

The Base URL for this API is `https://v1.intelligence.dudesolutions.io`



## Authentication
The type of authentication used by this API is: `OAuth v2 Bearer Token / Personal Access Token`



# <a name="api_reference"></a>API Reference

* [System Information](#system_information)
* [Heartbeat](#heartbeat)
* [Executive Summaries](#executive_summaries)
* [Scheduled Reports](#scheduled_reports)

## <a name="system_information"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "System Information") System Information


### <a name="get_system_information"></a>![Endpoint: ](https://apidocs.io/img/method.png "Get System Information") Get System Information


**`GET`** `/`

> TODO: Add a method description



#### Responses
**200** 

Body (_System Information_) 
```
{
  "application": "Dude Intelligence Api",
  "version": "1.0.0.0",
  "apiVersion": "1.0.0.0",
  "vitals": {
    "cachevitalcheck": true,
    "intelligencedbvitalcheck": true
  },
  "links": [
    {
      "endpoint": "WorkOrder",
      "action": "Get",
      "route": "/accounts/{accountId}/workorders"
    }
  ]
}
```


[Back to API Reference](#api_reference)

## <a name="heartbeat"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Heartbeat") Heartbeat


### <a name="get_heartbeat"></a>![Endpoint: ](https://apidocs.io/img/method.png "Get Heartbeat") Get Heartbeat


**`GET`** `/heartbeat`

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.



#### Responses
**200** 

Body (_Heartbeat_) 
```
{
  "cachevitalcheck": true,
  "intelligencedbvitalcheck": true
}
```


[Back to API Reference](#api_reference)

## <a name="executive_summaries"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Executive Summaries") Executive Summaries


### <a name="get_summary_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "Get Summary Collection") Get Summary Collection


**`GET`** `/accounts/{accountId}/executivesummaries`

> TODO: Add a method description



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| accountId | `number` |  ``` Required ```  | ID of the account in the form of an integer | `1011` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| page | `number` |  ``` Optional ```  | The page to request from the collection. | `1` | 
| pagesize | `number` |  ``` Optional ```  | The number of records to load in a page from the collection. | `1000` | 
| orderby | `string` |  ``` Optional ```  | A string describing the ordering to perform on the collection. | `Name asc` | 
| type | `string` |  ``` Optional ```  | The type of records to filter by. | `"Event"` | 

#### Responses
**200** 

Body (_Get Summary Collection response_) 
```
{
  "page": 1,
  "pageSize": 1000,
  "dataSize": 0,
  "total": 0,
  "data": [
    {
      "id": 1,
      "type": "\"Event\"",
      "name": "\"FileName\"",
      "date": "2016-08-21T19:13:19.5084411Z",
      "fileDescriptorId": 1234,
      "shareableUri": "http://google.com/?q=test",
      "size": 1028
    }
  ]
}
```


### <a name="post_summary_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "Post Summary Collection") Post Summary Collection


**`POST`** `/accounts/{accountId}/executivesummaries`

> TODO: Add a method description



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| accountId | `number` |  ``` Required ```  | ID of the account in the form of an integer | `1011` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| page | `number` |  ``` Optional ```  | The page to request from the collection. | `1` | 
| pagesize | `number` |  ``` Optional ```  | The number of records to load in a page from the collection. | `1000` | 
| orderby | `string` |  ``` Optional ```  | A string describing the ordering to perform on the collection. | `Name asc` | 
| type | `string` |  ``` Optional ```  | The type of records to filter by. | `"Event"` | 

#### Request Headers
>Accept=application/json;
>Content-Type=application/json;

#### Request Body
Raw 

|  Type | Tags | Description |
| ------| ---- |-------------| 
| `executive summary data` |  ``` Required ```  | TODO: Add a parameter description | 

 Example 
``` 
{
  "id": 234,
  "type": "type",
  "name": "name",
  "date": "2017-07-21T05:40:07.3461899Z",
  "fileDescriptorId": "234",
  "shareableUri": "shareableUri",
  "size": "234"
}
``` 

#### Responses
**200** 

Body (_Executive Summary Data_) 
```
{
  "id": 234,
  "type": "type",
  "name": "name",
  "date": "2017-07-21T05:40:07.3531949Z",
  "fileDescriptorId": "234",
  "shareableUri": "shareableUri",
  "size": "234"
}
```


### <a name="get_summary_collection_detail"></a>![Endpoint: ](https://apidocs.io/img/method.png "Get Summary Collection Detail") Get Summary Collection Detail


**`GET`** `/accounts/{accountId}/executivesummaries/{id}`

> TODO: Add a method description



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| accountId | `number` |  ``` Required ```  | ID of the account in the form of an integer | `1011` | 
| id | `number` |  ``` Required ```  | Id of the execute summary to be retrieved. | `1011` | 

#### Responses
**200** 

Body (_Executive Summary Data_) 
```
{
  "id": 1,
  "type": "\"Event\"",
  "name": "\"FileName\"",
  "date": "2016-08-21T19:13:19.5084411Z",
  "fileDescriptorId": 1234,
  "shareableUri": "http://google.com/?q=test",
  "size": 1028
}
```


### <a name="delete_summary_collection_detail"></a>![Endpoint: ](https://apidocs.io/img/method.png "Delete Summary Collection Detail") Delete Summary Collection Detail


**`DELETE`** `/accounts/{accountId}/executivesummaries/{id}`

> TODO: Add a method description



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| accountId | `number` |  ``` Required ```  | ID of the account in the form of an integer | `1011` | 
| id | `number` |  ``` Required ```  | Id of the execute summary to be retrieved. | `1011` | 

#### Responses
**200**


[Back to API Reference](#api_reference)

## <a name="scheduled_reports"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Scheduled Reports") Scheduled Reports


### <a name="get_scheduled_reports_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "Get Scheduled Reports Collection") Get Scheduled Reports Collection


**`GET`** `/accounts/{accountId}/scheduledreports`

> TODO: Add a method description



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| accountId | `number` |  ``` Required ```  | ID of the account in the form of an integer | `1011` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| page | `number` |  ``` Optional ```  | The page to request from the collection. | `1` | 
| pagesize | `number` |  ``` Optional ```  | The number of records to load in a page from the collection. | `1000` | 
| orderby | `string` |  ``` Optional ```  | A string describing the ordering to perform on the collection. | `Name asc` | 

#### Responses
**200** 

Body (_Get Scheduled Reports Collection response_) 
```
{
  "page": 1,
  "pageSize": 1000,
  "dataSize": 0,
  "total": 0,
  "data": [
    {
      "id": 1,
      "name": "\"FileName\"",
      "date": "2016-08-21T19:13:19.5084411Z",
      "fileDescriptorId": 1234,
      "shareableUri": "http://google.com/?q=test",
      "size": 1028
    }
  ]
}
```


### <a name="post_scheduled_reports_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "Post Scheduled Reports Collection") Post Scheduled Reports Collection


**`POST`** `/accounts/{accountId}/scheduledreports`

> TODO: Add a method description



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| accountId | `number` |  ``` Required ```  | ID of the account in the form of an integer | `1011` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| page | `number` |  ``` Optional ```  | The page to request from the collection. | `1` | 
| pagesize | `number` |  ``` Optional ```  | The number of records to load in a page from the collection. | `1000` | 
| orderby | `string` |  ``` Optional ```  | A string describing the ordering to perform on the collection. | `Name asc` | 

#### Request Headers
>Accept=application/json;
>Content-Type=application/json;

#### Request Body
Raw 

|  Type | Tags | Description |
| ------| ---- |-------------| 
| `scheduled report data` |  ``` Required ```  | TODO: Add a parameter description | 

 Example 
``` 
{
  "id": 234,
  "name": "name",
  "date": "2017-07-21T05:40:07.3531949Z",
  "fileDescriptorId": "234",
  "shareableUri": "shareableUri",
  "size": "234"
}
``` 

#### Responses
**200** 

Body (_Scheduled Report Data_) 
```
{
  "id": 234,
  "name": "name",
  "date": "2017-07-21T05:40:07.3541961Z",
  "fileDescriptorId": "234",
  "shareableUri": "shareableUri",
  "size": "234"
}
```


### <a name="get_scheduled_reports_collection_detail"></a>![Endpoint: ](https://apidocs.io/img/method.png "Get Scheduled Reports Collection Detail") Get Scheduled Reports Collection Detail


**`GET`** `/accounts/{accountId}/scheduledreports/{id}`

> TODO: Add a method description



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| accountId | `number` |  ``` Required ```  | ID of the account in the form of an integer | `1011` | 
| id | `number` |  ``` Required ```  | Id of the scheduled report to be retrieved. | `1011` | 

#### Responses
**200** 

Body (_Scheduled Report Data_) 
```
{
  "id": 1,
  "name": "\"FileName\"",
  "date": "2016-08-21T19:13:19.5084411Z",
  "fileDescriptorId": 1234,
  "shareableUri": "http://google.com/?q=test",
  "size": 1028
}
```


### <a name="delete_scheduled_reports_collection_detail"></a>![Endpoint: ](https://apidocs.io/img/method.png "Delete Scheduled Reports Collection Detail") Delete Scheduled Reports Collection Detail


**`DELETE`** `/accounts/{accountId}/scheduledreports/{id}`

> TODO: Add a method description



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| accountId | `number` |  ``` Required ```  | ID of the account in the form of an integer | `1011` | 
| id | `number` |  ``` Required ```  | Id of the scheduled report to be retrieved. | `1011` | 

#### Responses
**200**


[Back to API Reference](#api_reference)

