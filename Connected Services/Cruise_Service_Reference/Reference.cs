﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JTB_Airline_and_Cruise.Cruise_Service_Reference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Cruise_Service_Reference.Cruise_WebServiceSoap")]
    public interface Cruise_WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCruiseDataFromDB", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetCruiseDataFromDB(string CheckIn, string CheckOut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCruiseDataFromDB", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCruiseDataFromDBAsync(string CheckIn, string CheckOut);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Cruise_WebServiceSoapChannel : JTB_Airline_and_Cruise.Cruise_Service_Reference.Cruise_WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Cruise_WebServiceSoapClient : System.ServiceModel.ClientBase<JTB_Airline_and_Cruise.Cruise_Service_Reference.Cruise_WebServiceSoap>, JTB_Airline_and_Cruise.Cruise_Service_Reference.Cruise_WebServiceSoap {
        
        public Cruise_WebServiceSoapClient() {
        }
        
        public Cruise_WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Cruise_WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Cruise_WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Cruise_WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetCruiseDataFromDB(string CheckIn, string CheckOut) {
            return base.Channel.GetCruiseDataFromDB(CheckIn, CheckOut);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCruiseDataFromDBAsync(string CheckIn, string CheckOut) {
            return base.Channel.GetCruiseDataFromDBAsync(CheckIn, CheckOut);
        }
    }
}
