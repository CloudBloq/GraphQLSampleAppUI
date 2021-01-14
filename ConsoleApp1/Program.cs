using GraphQLSampleAppUI.DataAccess;
using GraphQLSampleAppUI.DataAccess.Model;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                int Id = 444;
                string completeQuery = $"query{{employeeById(id:{Id}){{age,department{{departmentId,name}}departmentId,email,employeeId,name}}}}";
                string graphQLQueryType = "employeeById";

                var result = await Query.ExceuteQueryAsyn<Employee>(graphQLQueryType, completeQuery);

                var tt = result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}


