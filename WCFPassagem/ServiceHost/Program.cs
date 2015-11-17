using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFPassagem;

namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(ClienteService));
            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), new Uri("http://localhost:8080/clientes"));
            try
            {
                host.Open();
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                host.Abort();
                Console.ReadLine();
            }
        }
    }
}
