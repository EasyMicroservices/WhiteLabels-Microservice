using EasyMicroservices.Cores.Database.Managers;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EasyMicroservices.Payments.VirtualServerForTests.TestResources
{
    public static class WhiteLabelResource
    {
        public static Dictionary<string, string> GetResources<TContext>(TContext context, string microseviceName)
            where TContext : RelationalCoreContext
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add(@$"GET /api/WhiteLabel/GetAll HTTP/1.1
*RequestSkipBody*"
,
@"HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Content-Length: 0

{""isSuccess"":true,""result"":[{""id"":1,""name"":""ProjectName""},{""id"":2,""name"":""TenantName"",""parentId"":1}]}");


            result.Add(@$"GET /api/Microservice/GetAll HTTP/1.1
*RequestSkipBody*"
,
@$"HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Content-Length: 0

{{""isSuccess"":true,""result"":[{{""id"":1,""name"":""{microseviceName}"",""description"":""Automatically added""}}]}}");


            result.Add(@$"POST /api/Microservice/Add HTTP/1.1
*RequestSkipBody*"
,
@"HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Content-Length: 0

{""isSuccess"":true,""result"": 1}");
            DefaultUniqueIdentityManager defaultUniqueIdentityManager = new DefaultUniqueIdentityManager();
            List<TestMicroserviceContextTable> microserviceContextTables = new List<TestMicroserviceContextTable>();
            List<TestContextTableContract> contextTables = new List<TestContextTableContract>();
            int id = 1;
            foreach (var item in context.Model.GetEntityTypes())
            {
                contextTables.Add(new TestContextTableContract()
                {
                    Id = id,
                    ContextName = defaultUniqueIdentityManager.GetContextName(context.GetType()),
                    TableName = item.GetTableName()
                });
                microserviceContextTables.Add(new TestMicroserviceContextTable()
                {
                    MicroserviceId = 1,
                    MicroserviceName = microseviceName,
                    ContextTableId = id,
                    ContextName = defaultUniqueIdentityManager.GetContextName(context.GetType()),
                    TableName = item.GetTableName()
                });
                id++;
            }
            result.Add(@$"GET /api/MicroserviceContextTable/GetAll HTTP/1.1
*RequestSkipBody*"
,
@$"HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Content-Length: 0

{{""isSuccess"":true,""result"":{Newtonsoft.Json.JsonConvert.SerializeObject(microserviceContextTables)}}}");

            
            result.Add(@$"GET /api/ContextTable/GetAll HTTP/1.1
*RequestSkipBody*"
            ,
            @$"HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Content-Length: 0

{{""isSuccess"":true,""result"":{Newtonsoft.Json.JsonConvert.SerializeObject(contextTables)}}}");


            return result;
        }
    }

    internal class TestMicroserviceContextTable
    {
        public string MicroserviceName { get; set; }
        public int MicroserviceId { get; set; }
        public string ContextName { get; set; }
        public string TableName { get; set; }
        public int ContextTableId { get; set; }
    }

    internal class TestContextTableContract
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string ContextName { get; set; }
    }
}
