using app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ClienteService));
            Uri endereco = new Uri("http://localhost:8080/clientes");

            host.AddServiceEndpoint(typeof(ClienteService), new BasicHttpBinding(), endereco);

            try {
                host.Open();
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex) {
                host.Abort();
                Console.ReadKey();
            }

        }

        public static void ExibeIformacoes(ServiceHost sh) {
            Console.WriteLine("{0} online", sh.Description.ServiceType);
            foreach (ServiceEndpoint se in sh.Description.Endpoints) {
                Console.WriteLine(se.Address);
            }
        }
    }
}
