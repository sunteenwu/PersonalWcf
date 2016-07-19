using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WCFClient.ServiceReference1;
using System.Security.Principal;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用BasicHttpBinding绑定
            BasicHttpBinding myBinding = new BasicHttpBinding();
            //使用Transport安全模式
            myBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            //客户端验证为None
            myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            //客户端验证为Basic
            //myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            //客户端验证为Ntlm
            //myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;

            //客户端Endpoint地址，指向服务端Endpoint的地址
            EndpointAddress ea = new
                EndpointAddress("https://win2008/WcfIISHostService/Service1.svc/GetIdentity");

            GetIdentityClient gc = new GetIdentityClient(myBinding, ea);

            //客户端为Basic时，客户端提供用户名和密码
            //gc.ClientCredentials.UserName.UserName = "chnking";
            //gc.ClientCredentials.UserName.Password = "jjz666";


            //执行代理类Get方法
            string result = gc.Get(WindowsIdentity.GetCurrent().Name);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
