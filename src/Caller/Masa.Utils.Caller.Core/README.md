[中](README.zh-CN.md) | EN

## Masa.Utils.Caller.Core

Responsibilities:

For calls between abstract services, the caller does not need to pay too much attention to whether it is a normal Http request or a request through Dapr Sidecar, which can reduce the impact of different deployment methods on business code, and Caller also provides exception handling by default. Requests that fail to be called will throw exceptions, making service calls as simple as method calls and friendly to developers

Two implementations are currently supported

* [Masa.Utils.Caller.HttpClient](../Masa.Utils.Caller.HttpClient/README.zh-CN.md)
* Masa.Utils.Caller.DaprClient

### What functions does CallerProvider provide

#### Get request

* GetStringAsync: Response to Get request with string content
* GetByteArrayAsync: Response to Get request with byte array
* GetStreamAsync: Response to Get requests with stream content
* GetAsync: supports generic type Get requests

#### Post request

* PostAsync: new request

#### Put request

* PutAsync: full update request

#### Delete request

* DeleteAsync: delete request

#### Patch Request

* PatchAsync: partial update request

#### Send request

* SendAsync: basic Http request, you can specify the request method, request address, request header, request parameters, request content, etc.


### Example

Other request methods are similar to Get requests. Let's take common Get requests as an example:

Suppose we have specified the BaseAddress address of CallerProvider: http://localhost:5000

* No parameters, request address: http://localhost:5000/Check/Healthy

    ````c#
    app.MapGet("/Test/Check/Healthy", ([FromServices] ICallerProvider callerProvider)
        => callerProvider.GetStringAsync("Check/Healthy"));
    ````
* With parameters, request address: http://localhost:5000/Check/Healthy?date=1650550669

    ````c#
    app.MapGet("/Test/Check/Healthy", ([FromServices] ICallerProvider callerProvider)
        => callerProvider.GetStringAsync("Check/Healthy", new { date = 1650550669 }));
    ````

* With parameters, there are response values, request address: http://localhost:5000/User/Get?id=1

    The response information is:
    ````json
    {
        "Id": 1,
        "Name": "Masa",
        "Age": 18
    }
    ````

    Newly added class `UserDto`
    ````
    publi class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
    ````

    Full code:

    ````c#
    app.MapGet("/User/Get", ([FromServices] ICallerProvider callerProvider)
        => callerProvider.GetAsync<object, UserDto>("Check/Healthy", new { id = 1 }));
    ````