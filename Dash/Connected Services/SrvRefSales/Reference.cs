﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dash.SrvRefSales {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SrvRefSales.WSForSalesSoap")]
    public interface WSForSalesSoap {
        
        // CODEGEN: Generating message contract since element name GetSalesDataResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSalesData", ReplyAction="*")]
        Dash.SrvRefSales.GetSalesDataResponse GetSalesData(Dash.SrvRefSales.GetSalesDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSalesData", ReplyAction="*")]
        System.Threading.Tasks.Task<Dash.SrvRefSales.GetSalesDataResponse> GetSalesDataAsync(Dash.SrvRefSales.GetSalesDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSalesDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSalesData", Namespace="http://tempuri.org/", Order=0)]
        public Dash.SrvRefSales.GetSalesDataRequestBody Body;
        
        public GetSalesDataRequest() {
        }
        
        public GetSalesDataRequest(Dash.SrvRefSales.GetSalesDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetSalesDataRequestBody {
        
        public GetSalesDataRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSalesDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSalesDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public Dash.SrvRefSales.GetSalesDataResponseBody Body;
        
        public GetSalesDataResponse() {
        }
        
        public GetSalesDataResponse(Dash.SrvRefSales.GetSalesDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetSalesDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetSalesDataResult;
        
        public GetSalesDataResponseBody() {
        }
        
        public GetSalesDataResponseBody(string GetSalesDataResult) {
            this.GetSalesDataResult = GetSalesDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSForSalesSoapChannel : Dash.SrvRefSales.WSForSalesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSForSalesSoapClient : System.ServiceModel.ClientBase<Dash.SrvRefSales.WSForSalesSoap>, Dash.SrvRefSales.WSForSalesSoap {
        
        public WSForSalesSoapClient() {
        }
        
        public WSForSalesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSForSalesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSForSalesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSForSalesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dash.SrvRefSales.GetSalesDataResponse Dash.SrvRefSales.WSForSalesSoap.GetSalesData(Dash.SrvRefSales.GetSalesDataRequest request) {
            return base.Channel.GetSalesData(request);
        }
        
        public string GetSalesData() {
            Dash.SrvRefSales.GetSalesDataRequest inValue = new Dash.SrvRefSales.GetSalesDataRequest();
            inValue.Body = new Dash.SrvRefSales.GetSalesDataRequestBody();
            Dash.SrvRefSales.GetSalesDataResponse retVal = ((Dash.SrvRefSales.WSForSalesSoap)(this)).GetSalesData(inValue);
            return retVal.Body.GetSalesDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Dash.SrvRefSales.GetSalesDataResponse> Dash.SrvRefSales.WSForSalesSoap.GetSalesDataAsync(Dash.SrvRefSales.GetSalesDataRequest request) {
            return base.Channel.GetSalesDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<Dash.SrvRefSales.GetSalesDataResponse> GetSalesDataAsync() {
            Dash.SrvRefSales.GetSalesDataRequest inValue = new Dash.SrvRefSales.GetSalesDataRequest();
            inValue.Body = new Dash.SrvRefSales.GetSalesDataRequestBody();
            return ((Dash.SrvRefSales.WSForSalesSoap)(this)).GetSalesDataAsync(inValue);
        }
    }
}
