﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.VelibReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VelibReference.IService1", CallbackContract=typeof(ConsoleApp1.VelibReference.IService1Callback))]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBike", ReplyAction="http://tempuri.org/IService1/GetBikeResponse")]
        void GetBike(string numberToFind, string j);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBike", ReplyAction="http://tempuri.org/IService1/GetBikeResponse")]
        System.Threading.Tasks.Task GetBikeAsync(string numberToFind, string j);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SubscribedGetVelibEvent", ReplyAction="http://tempuri.org/IService1/SubscribedGetVelibEventResponse")]
        void SubscribedGetVelibEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SubscribedGetVelibEvent", ReplyAction="http://tempuri.org/IService1/SubscribedGetVelibEventResponse")]
        System.Threading.Tasks.Task SubscribedGetVelibEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SusbcribedGetVelibFinishedEvent", ReplyAction="http://tempuri.org/IService1/SusbcribedGetVelibFinishedEventResponse")]
        void SusbcribedGetVelibFinishedEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SusbcribedGetVelibFinishedEvent", ReplyAction="http://tempuri.org/IService1/SusbcribedGetVelibFinishedEventResponse")]
        System.Threading.Tasks.Task SusbcribedGetVelibFinishedEventAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Callback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/getTheVelibInStation")]
        void getTheVelibInStation(string city, string station, string result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/getTheVelibFinished")]
        void getTheVelibFinished();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleApp1.VelibReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.DuplexClientBase<ConsoleApp1.VelibReference.IService1>, ConsoleApp1.VelibReference.IService1 {
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void GetBike(string numberToFind, string j) {
            base.Channel.GetBike(numberToFind, j);
        }
        
        public System.Threading.Tasks.Task GetBikeAsync(string numberToFind, string j) {
            return base.Channel.GetBikeAsync(numberToFind, j);
        }
        
        public void SubscribedGetVelibEvent() {
            base.Channel.SubscribedGetVelibEvent();
        }
        
        public System.Threading.Tasks.Task SubscribedGetVelibEventAsync() {
            return base.Channel.SubscribedGetVelibEventAsync();
        }
        
        public void SusbcribedGetVelibFinishedEvent() {
            base.Channel.SusbcribedGetVelibFinishedEvent();
        }
        
        public System.Threading.Tasks.Task SusbcribedGetVelibFinishedEventAsync() {
            return base.Channel.SusbcribedGetVelibFinishedEventAsync();
        }
    }
}
