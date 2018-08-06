﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ILogin")]
    public interface ILogin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogin/Authenticate", ReplyAction="http://tempuri.org/ILogin/AuthenticateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/ILogin/AuthenticateArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool Authenticate(int id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogin/Authenticate", ReplyAction="http://tempuri.org/ILogin/AuthenticateResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateAsync(int id, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginChannel : Client.ServiceReference1.ILogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginClient : System.ServiceModel.ClientBase<Client.ServiceReference1.ILogin>, Client.ServiceReference1.ILogin {
        
        public LoginClient() {
        }
        
        public LoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Authenticate(int id, string password) {
            return base.Channel.Authenticate(id, password);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateAsync(int id, string password) {
            return base.Channel.AuthenticateAsync(id, password);
        }
    }
}
