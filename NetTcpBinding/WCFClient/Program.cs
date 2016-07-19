using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Text;
using WCFClient.ServiceReference1;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.Security.Principal;
using System.ServiceModel.Configuration;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            NetTcpBinding myBinding = new NetTcpBinding();
            //myBinding.Security.Mode = SecurityMode.None;
            //myBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.None;
            myBinding.Security.Mode = SecurityMode.Transport;
            myBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            EndpointAddress ea = new EndpointAddress("net.tcp://localhost:8056/WCFService/GetIdentity");
            GetIdentityClient gc = new GetIdentityClient(myBinding, ea);
           // gc.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =System.ServiceModel.Security.X509CertificateValidationMode.None;         
            ClientViaBehavior myClientViaBehavior = new ClientViaBehavior
                (new Uri("net.tcp://localhost:8057/WCFService/GetIdentity"));
            //gc.Endpoint.Behaviors.Add(myClientViaBehavior);    
            string result = gc.Get(WindowsIdentity.GetCurrent().Name);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
