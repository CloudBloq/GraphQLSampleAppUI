using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GraphQLSampleAppUI.DataAccess
{
    public class Mutation
    {
        private static GraphQLHttpClient graphQLHttpClient;

        static Mutation()
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
                
                var response = await graphQLHttpClient.SendMutationAsync<object>(request);

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
