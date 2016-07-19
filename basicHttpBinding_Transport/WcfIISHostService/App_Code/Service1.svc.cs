using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Security.Principal;
using System.Threading;
using System.Security.Permissions;

namespace WcfIISHostService
{

    [ServiceContract(Namespace = "http://chnking.com")]
    public interface IGetIdentity
    {
        [OperationContract]
        string Get(string ClientIdentity);
    }

    public class GetIdentity : IGetIdentity
    {
        //[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
        public string Get(string ClientIdentity)
        {
            return ("服务端Identity 是 '" + ServiceSecurityContext.Current.WindowsIdentity.Name +
                "'\n\r客户端Identity 是 '" + ClientIdentity + "'");

        }
    }
}
