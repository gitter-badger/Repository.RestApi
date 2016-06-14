using System;
using Newtonsoft.Json;

namespace Repository.RestApi
{
    public class RestApiRepository
    {
        public ISet<TestElement> Test1 { get; } = new RestApiSet<TestElement>(new Uri("https://blockchain.info"), "/rawblock/{Id}", new JsonSerializerSettings());
    }
}