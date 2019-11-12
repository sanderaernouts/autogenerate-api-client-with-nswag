using System;
using System.Net.Http;
using System.Threading.Tasks;
using Example.Api.Client.CSharp.Contracts;

namespace Example.Api.Client.CSharp
{
    public static class ClientFactory
    {
        public static IValuesClient CreateValuesClient(string baseUrl, HttpClient http, Func<Task<string>> retrieveAuthorizationToken)
        {
            return new ValuesClient(baseUrl, http)
            {
                RetrieveAuthorizationToken = retrieveAuthorizationToken
            };
        }
    }
}
