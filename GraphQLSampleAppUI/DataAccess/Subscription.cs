using GraphQL;
using GraphQL.Client.Http;
using ModernHttpClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;


namespace GraphQLSampleAppUI.DataAccess
{   
    public class Subscription
    {
        private static GraphQLHttpClient graphQLHttpClient;

        static Subscription()
        {
            var uri = new Uri("https://localhost:44351/graphql");
            var graphQLOptions = new GraphQLHttpClientOptions
            {
                EndPoint = uri,
                HttpMessageHandler = new NativeMessageHandler(),
            };

            graphQLHttpClient = new GraphQLHttpClient(graphQLOptions, new NewtonsoftJsonSerializer());
        }

       
        public static async Task<T> ExceuteMutationAsyn<T>(string graphQLQueryType, string completeQueryString)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = completeQueryString
                };

                var response = await graphQLHttpClient.SendQueryAsync<object>(request);

                var stringResult = response.Data.ToString();
                stringResult = stringResult.Replace($"\"{graphQLQueryType}\":", string.Empty);
                stringResult = stringResult.Remove(0, 1);
                stringResult = stringResult.Remove(stringResult.Length - 1, 1);

                var result = JsonConvert.DeserializeObject<T>(stringResult);

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
