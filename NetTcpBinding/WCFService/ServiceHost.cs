using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCFService
{

    internal class MyServiceHost
    {
        internal static ServiceHost myServiceHost = null;

        internal static void Main()
        {
             NetTcpBinding myBinding = new NetTcpBinding();
            myBinding.Security.Mode = SecurityMode.None;
            myBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.None;

            //myBinding.Security.Mode = SecurityMode.Transport;
            //myBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            //myBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.None;


            Uri baseAddress = new Uri("net.tcp://localhost:8056/WCFService/");

            myServiceHost = new ServiceHost(typeof(GetIdentity), baseAddress);
            ServiceEndpoint myServiceEndpoint = myServiceHost.AddServiceEndpoint
                (typeof(IGetIdentity), myBinding, "GetIdentity");
            myServiceHost.Credentials.ServiceCertificate.SetCertificate("CN=localhost");


            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            behavior.HttpGetEnabled = true;
            behavior.HttpGetUrl = new Uri("http://localhost:8057/mex");
            myServiceHost.Description.Behaviors.Add(behavior);

            myServiceHost.Open();
            Console.WriteLine("Service started!");
            Console.ReadLine();
            myServiceHost.Close();

            //UdpBinding myBinding = new UdpBinding();

            ////myBinding.Security.Mode = SecurityMode.None;
            ////myBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.None;

            //myBinding.Security.Mode = SecurityMode.Transport;
            //myBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            ////myBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.None;


            //Uri baseAddress = new Uri("net.tcp://localhost:8056/WCFService/");

            //myServiceHost = new ServiceHost(typeof(GetIdentity), baseAddress);
            //ServiceEndpoint myServiceEndpoint = myServiceHost.AddServiceEndpoint
            //    (typeof(IGetIdentity), myBinding, "GetIdentity");
            //myServiceHost.Credentials.ServiceCertificate.SetCertificate("CN=localhost");


            //ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            //behavior.HttpGetEnabled = true;
            //behavior.HttpGetUrl = new Uri("http://localhost:8057/mex");
            //myServiceHost.Description.Behaviors.Add(behavior);

            //myServiceHost.Open();
            //Console.WriteLine("Service started!");
            //Console.ReadLine();
            //myServiceHost.Close();
        }
    }
}

