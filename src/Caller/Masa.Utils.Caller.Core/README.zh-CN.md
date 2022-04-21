中 | [EN](README.md)

## Masa.Utils.Caller.Core

职责：

抽象服务间调用，调用者不需要过多关注是普通的Http请求还是通过Dapr Sidecar的请求，可以降低不同的部署方式对业务代码带来的影响，并且Caller还默认提供了异常处理的功能，针对调用失败的请求，会抛出异常，让服务调用变得像方法调用一样简单，对开发者友好

目前支持了两种实现方式

* [Masa.Utils.Caller.HttpClient](../Masa.Utils.Caller.HttpClient/README.zh-CN.md)
* Masa.Utils.Caller.DaprClient

### CallerProvider 提供了哪些功能

#### Get 请求

* GetStringAsync: 响应内容为字符串的Get请求
* GetByteArrayAsync: 响应内容为字节数组的Get请求
* GetStreamAsync: 响应内容为流的Get请求
* GetAsync: 支持泛型类型的Get请求

#### Post 请求

* PostAsync: 新增请求

#### Put 请求

* PutAsync: 全量更新请求

#### Delete 请求

* DeleteAsync: 删除请求

#### Patch 请求

* PatchAsync: 局部更新请求

#### Send请求

* SendAsync: 基础的Http请求，可以指定请求方法、请求地址、请求头、请求参数、请求内容等


### 示例

其他请求方式与Get请求类似，我们拿常见的Get请求举例:

假设我们已经指定了CallerProvider的BaseAddress地址：http://localhost:5000

* 无参数，请求地址：http://localhost:5000/Check/Healthy

    ```c#
    app.MapGet("/Test/Check/Healthy", ([FromServices] ICallerProvider callerProvider)
        => callerProvider.GetStringAsync("Check/Healthy"));
    ```
* 带参数，请求地址：http://localhost:5000/Check/Healthy?date=1650550669

    ```c#
    app.MapGet("/Test/Check/Healthy", ([FromServices] ICallerProvider callerProvider)
        => callerProvider.GetStringAsync("Check/Healthy", new { date = 1650550669 }));
    ```

* 带参数，有响应值，请求地址: http://localhost:5000/User/Get?id=1

    响应信息为：
    ```json
    {
        "Id": 1,
        "Name": "Masa",
        "Age": 18
    }
    ```

    新添加类`UserDto`
    ```
    publi class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
    ```

    完整代码：

    ```c#
    app.MapGet("/User/Get", ([FromServices] ICallerProvider callerProvider)
        => callerProvider.GetAsync<object, UserDto>("Check/Healthy", new { id = 1 }));
    ```