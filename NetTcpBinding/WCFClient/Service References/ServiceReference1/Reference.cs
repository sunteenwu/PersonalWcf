﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://chnking.com", ConfigurationName="ServiceReference1.IGetIdentity")]
    public interface IGetIdentity {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://chnking.com/IGetIdentity/Get", ReplyAction="http://chnking.com/IGetIdentity/GetResponse")]
        string Get(string ClientIdentity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetIdentityChannel : WCFClient.ServiceReference1.IGetIdentity, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetIdentityClient : System.ServiceModel.ClientBase<WCFClient.ServiceReference1.IGetIdentity>, WCFClient.ServiceReference1.IGetIdentity {
        
        public GetIdentityClient() {
        }
        
        public GetIdentityClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetIdentityClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetIdentityClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetIdentityClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Get(string ClientIdentity) {
            return base.Channel.Get(ClientIdentity);
        }
    }
}
