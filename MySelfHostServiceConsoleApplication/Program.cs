using System;
using System.ServiceModel;

namespace MySelfHostServiceConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CustomerService), new Uri[] { });
            host.Open();
            Console.WriteLine("Serviço iniciado!");
            Console.WriteLine("Serviço rodando...");
            Console.WriteLine("Tecle ENTER para finalizar.");
            Console.ReadKey();
            host.Close();
        }
    }
}
