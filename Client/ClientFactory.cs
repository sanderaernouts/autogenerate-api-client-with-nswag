using System;
using System.Net.Http;
using System.Threading.Tasks;
using Example.Api.Client.Contracts;

namespace Example.Api.Client
{
    public static class ClientFactory
    {
        public static IValuesClient CreateModelsClient(string baseUrl, HttpClient http, Func<Task<string>> retrieveAuthorizationToken)
        {
            return new ValuesClient(baseUrl, http)
            {
                RetrieveAuthorizationToken = retrieveAuthorizationToken
            };
        }
    }
}
