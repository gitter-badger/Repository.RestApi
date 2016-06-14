using System;
using System.Linq;
using Repository.RestApi;

namespace Repository.RetpApi.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new RestApiRepository();
            var elements = from element in repository.Test1 where element.Id == 2 select element;

            foreach (var element in elements)
            {
                Console.WriteLine(element.Id);
            }
        }
    }
}