﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JTB_Airline_and_Cruise.AirLine_Service_Reference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://JTBAirLineandCruise.com/", ConfigurationName="AirLine_Service_Reference.Airline_WebServiceSoap")]
    public interface Airline_WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://JTBAirLineandCruise.com/GetResevationDataFromDB", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetResevationDataFromDB(string Departure, string Location, string StartDate, string Departure_Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://JTBAirLineandCruise.com/GetResevationDataFromDB", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetResevationDataFromDBAsync(string Departure, string Location, string StartDate, string Departure_Date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Airline_WebServiceSoapChannel : JTB_Airline_and_Cruise.AirLine_Service_Reference.Airline_WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Airline_WebServiceSoapClient : System.ServiceModel.ClientBase<JTB_Airline_and_Cruise.AirLine_Service_Reference.Airline_WebServiceSoap>, JTB_Airline_and_Cruise.AirLine_Service_Reference.Airline_WebServiceSoap {
        
        public Airline_WebServiceSoapClient() {
        }
        
        public Airline_WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Airline_WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Airline_WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Airline_WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetResevationDataFromDB(string Departure, string Location, string StartDate, string Departure_Date) {
            return base.Channel.GetResevationDataFromDB(Departure, Location, StartDate, Departure_Date);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetResevationDataFromDBAsync(string Departure, string Location, string StartDate, string Departure_Date) {
            return base.Channel.GetResevationDataFromDBAsync(Departure, Location, StartDate, Departure_Date);
        }
    }
}
