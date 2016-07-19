using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Discovery;
using System.Text;
using System.Threading.Tasks;

namespace Discover
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscoveryClient discoveryClient = new DiscoveryClient(new UdpDiscoveryEndpoint());
            // Create FindCriteria
            FindCriteria findCriteria = new FindCriteria(typeof(IGetIdentity));          
            findCriteria.Duration = TimeSpan.FromSeconds(10);

            // Find ICalculatorService endpoints            
            FindResponse findResponse = discoveryClient.Find(findCriteria);
            Console.WriteLine("Found {0} IGetIdentity endpoint(s).", findResponse.Endpoints.Count);
            Console.ReadLine();
        }
    }

    [ServiceContract]
    public interface IGetIdentity
    {
        //[OperationContract]
        //string Get(string ClientIdentity);
    }
}
