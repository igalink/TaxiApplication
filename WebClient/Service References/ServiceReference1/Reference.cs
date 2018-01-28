﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceTaxiSoap")]
    public interface WebServiceTaxiSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем driver из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrateDriver", ReplyAction="*")]
        WebClient.ServiceReference1.RegistrateDriverResponse RegistrateDriver(WebClient.ServiceReference1.RegistrateDriverRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrateDriver", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.RegistrateDriverResponse> RegistrateDriverAsync(WebClient.ServiceReference1.RegistrateDriverRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем customer из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrateCustomer", ReplyAction="*")]
        WebClient.ServiceReference1.RegistrateCustomerResponse RegistrateCustomer(WebClient.ServiceReference1.RegistrateCustomerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrateCustomer", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.RegistrateCustomerResponse> RegistrateCustomerAsync(WebClient.ServiceReference1.RegistrateCustomerRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем authorization из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Authorize", ReplyAction="*")]
        WebClient.ServiceReference1.AuthorizeResponse Authorize(WebClient.ServiceReference1.AuthorizeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Authorize", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.AuthorizeResponse> AuthorizeAsync(WebClient.ServiceReference1.AuthorizeRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем GetListOfOrdersResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListOfOrders", ReplyAction="*")]
        WebClient.ServiceReference1.GetListOfOrdersResponse GetListOfOrders(WebClient.ServiceReference1.GetListOfOrdersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListOfOrders", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.GetListOfOrdersResponse> GetListOfOrdersAsync(WebClient.ServiceReference1.GetListOfOrdersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrder", ReplyAction="*")]
        void GetOrder(System.Guid idDriver, System.Guid idOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrder", ReplyAction="*")]
        System.Threading.Tasks.Task GetOrderAsync(System.Guid idDriver, System.Guid idOrder);
        
        // CODEGEN: Контракт генерации сообщений с именем order из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateOrder", ReplyAction="*")]
        WebClient.ServiceReference1.CreateOrderResponse CreateOrder(WebClient.ServiceReference1.CreateOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.CreateOrderResponse> CreateOrderAsync(WebClient.ServiceReference1.CreateOrderRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем ShowOrderResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowOrder", ReplyAction="*")]
        WebClient.ServiceReference1.ShowOrderResponse ShowOrder(WebClient.ServiceReference1.ShowOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.ShowOrderResponse> ShowOrderAsync(WebClient.ServiceReference1.ShowOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CancellationOfOrder", ReplyAction="*")]
        void CancellationOfOrder(System.Guid idClient, System.Guid idOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CancellationOfOrder", ReplyAction="*")]
        System.Threading.Tasks.Task CancellationOfOrderAsync(System.Guid idClient, System.Guid idOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StartTrip", ReplyAction="*")]
        void StartTrip(System.Guid idDriver, System.Guid idOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StartTrip", ReplyAction="*")]
        System.Threading.Tasks.Task StartTripAsync(System.Guid idDriver, System.Guid idOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FinishTrip", ReplyAction="*")]
        void FinishTrip(System.Guid idDriver, System.Guid idOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FinishTrip", ReplyAction="*")]
        System.Threading.Tasks.Task FinishTripAsync(System.Guid idDriver, System.Guid idOrder);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrateDriverRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrateDriver", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.RegistrateDriverRequestBody Body;
        
        public RegistrateDriverRequest() {
        }
        
        public RegistrateDriverRequest(WebClient.ServiceReference1.RegistrateDriverRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrateDriverRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string driver;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string authorization;
        
        public RegistrateDriverRequestBody() {
        }
        
        public RegistrateDriverRequestBody(string driver, string authorization) {
            this.driver = driver;
            this.authorization = authorization;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrateDriverResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrateDriverResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.RegistrateDriverResponseBody Body;
        
        public RegistrateDriverResponse() {
        }
        
        public RegistrateDriverResponse(WebClient.ServiceReference1.RegistrateDriverResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrateDriverResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool RegistrateDriverResult;
        
        public RegistrateDriverResponseBody() {
        }
        
        public RegistrateDriverResponseBody(bool RegistrateDriverResult) {
            this.RegistrateDriverResult = RegistrateDriverResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrateCustomerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrateCustomer", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.RegistrateCustomerRequestBody Body;
        
        public RegistrateCustomerRequest() {
        }
        
        public RegistrateCustomerRequest(WebClient.ServiceReference1.RegistrateCustomerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrateCustomerRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string customer;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string authorization;
        
        public RegistrateCustomerRequestBody() {
        }
        
        public RegistrateCustomerRequestBody(string customer, string authorization) {
            this.customer = customer;
            this.authorization = authorization;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrateCustomerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrateCustomerResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.RegistrateCustomerResponseBody Body;
        
        public RegistrateCustomerResponse() {
        }
        
        public RegistrateCustomerResponse(WebClient.ServiceReference1.RegistrateCustomerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrateCustomerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool RegistrateCustomerResult;
        
        public RegistrateCustomerResponseBody() {
        }
        
        public RegistrateCustomerResponseBody(bool RegistrateCustomerResult) {
            this.RegistrateCustomerResult = RegistrateCustomerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthorizeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Authorize", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.AuthorizeRequestBody Body;
        
        public AuthorizeRequest() {
        }
        
        public AuthorizeRequest(WebClient.ServiceReference1.AuthorizeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthorizeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string authorization;
        
        public AuthorizeRequestBody() {
        }
        
        public AuthorizeRequestBody(string authorization) {
            this.authorization = authorization;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthorizeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthorizeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.AuthorizeResponseBody Body;
        
        public AuthorizeResponse() {
        }
        
        public AuthorizeResponse(WebClient.ServiceReference1.AuthorizeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthorizeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.Guid AuthorizeResult;
        
        public AuthorizeResponseBody() {
        }
        
        public AuthorizeResponseBody(System.Guid AuthorizeResult) {
            this.AuthorizeResult = AuthorizeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListOfOrdersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListOfOrders", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.GetListOfOrdersRequestBody Body;
        
        public GetListOfOrdersRequest() {
        }
        
        public GetListOfOrdersRequest(WebClient.ServiceReference1.GetListOfOrdersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListOfOrdersRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.Guid idClient;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int role;
        
        public GetListOfOrdersRequestBody() {
        }
        
        public GetListOfOrdersRequestBody(System.Guid idClient, int role) {
            this.idClient = idClient;
            this.role = role;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListOfOrdersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListOfOrdersResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.GetListOfOrdersResponseBody Body;
        
        public GetListOfOrdersResponse() {
        }
        
        public GetListOfOrdersResponse(WebClient.ServiceReference1.GetListOfOrdersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListOfOrdersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetListOfOrdersResult;
        
        public GetListOfOrdersResponseBody() {
        }
        
        public GetListOfOrdersResponseBody(string GetListOfOrdersResult) {
            this.GetListOfOrdersResult = GetListOfOrdersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateOrder", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.CreateOrderRequestBody Body;
        
        public CreateOrderRequest() {
        }
        
        public CreateOrderRequest(WebClient.ServiceReference1.CreateOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateOrderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string order;
        
        public CreateOrderRequestBody() {
        }
        
        public CreateOrderRequestBody(string order) {
            this.order = order;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.CreateOrderResponseBody Body;
        
        public CreateOrderResponse() {
        }
        
        public CreateOrderResponse(WebClient.ServiceReference1.CreateOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CreateOrderResponseBody {
        
        public CreateOrderResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowOrder", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.ShowOrderRequestBody Body;
        
        public ShowOrderRequest() {
        }
        
        public ShowOrderRequest(WebClient.ServiceReference1.ShowOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ShowOrderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.Guid idClient;
        
        public ShowOrderRequestBody() {
        }
        
        public ShowOrderRequestBody(System.Guid idClient) {
            this.idClient = idClient;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference1.ShowOrderResponseBody Body;
        
        public ShowOrderResponse() {
        }
        
        public ShowOrderResponse(WebClient.ServiceReference1.ShowOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ShowOrderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ShowOrderResult;
        
        public ShowOrderResponseBody() {
        }
        
        public ShowOrderResponseBody(string ShowOrderResult) {
            this.ShowOrderResult = ShowOrderResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceTaxiSoapChannel : WebClient.ServiceReference1.WebServiceTaxiSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceTaxiSoapClient : System.ServiceModel.ClientBase<WebClient.ServiceReference1.WebServiceTaxiSoap>, WebClient.ServiceReference1.WebServiceTaxiSoap {
        
        public WebServiceTaxiSoapClient() {
        }
        
        public WebServiceTaxiSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceTaxiSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceTaxiSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceTaxiSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ServiceReference1.RegistrateDriverResponse WebClient.ServiceReference1.WebServiceTaxiSoap.RegistrateDriver(WebClient.ServiceReference1.RegistrateDriverRequest request) {
            return base.Channel.RegistrateDriver(request);
        }
        
        public bool RegistrateDriver(string driver, string authorization) {
            WebClient.ServiceReference1.RegistrateDriverRequest inValue = new WebClient.ServiceReference1.RegistrateDriverRequest();
            inValue.Body = new WebClient.ServiceReference1.RegistrateDriverRequestBody();
            inValue.Body.driver = driver;
            inValue.Body.authorization = authorization;
            WebClient.ServiceReference1.RegistrateDriverResponse retVal = ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).RegistrateDriver(inValue);
            return retVal.Body.RegistrateDriverResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.RegistrateDriverResponse> WebClient.ServiceReference1.WebServiceTaxiSoap.RegistrateDriverAsync(WebClient.ServiceReference1.RegistrateDriverRequest request) {
            return base.Channel.RegistrateDriverAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.RegistrateDriverResponse> RegistrateDriverAsync(string driver, string authorization) {
            WebClient.ServiceReference1.RegistrateDriverRequest inValue = new WebClient.ServiceReference1.RegistrateDriverRequest();
            inValue.Body = new WebClient.ServiceReference1.RegistrateDriverRequestBody();
            inValue.Body.driver = driver;
            inValue.Body.authorization = authorization;
            return ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).RegistrateDriverAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ServiceReference1.RegistrateCustomerResponse WebClient.ServiceReference1.WebServiceTaxiSoap.RegistrateCustomer(WebClient.ServiceReference1.RegistrateCustomerRequest request) {
            return base.Channel.RegistrateCustomer(request);
        }
        
        public bool RegistrateCustomer(string customer, string authorization) {
            WebClient.ServiceReference1.RegistrateCustomerRequest inValue = new WebClient.ServiceReference1.RegistrateCustomerRequest();
            inValue.Body = new WebClient.ServiceReference1.RegistrateCustomerRequestBody();
            inValue.Body.customer = customer;
            inValue.Body.authorization = authorization;
            WebClient.ServiceReference1.RegistrateCustomerResponse retVal = ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).RegistrateCustomer(inValue);
            return retVal.Body.RegistrateCustomerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.RegistrateCustomerResponse> WebClient.ServiceReference1.WebServiceTaxiSoap.RegistrateCustomerAsync(WebClient.ServiceReference1.RegistrateCustomerRequest request) {
            return base.Channel.RegistrateCustomerAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.RegistrateCustomerResponse> RegistrateCustomerAsync(string customer, string authorization) {
            WebClient.ServiceReference1.RegistrateCustomerRequest inValue = new WebClient.ServiceReference1.RegistrateCustomerRequest();
            inValue.Body = new WebClient.ServiceReference1.RegistrateCustomerRequestBody();
            inValue.Body.customer = customer;
            inValue.Body.authorization = authorization;
            return ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).RegistrateCustomerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ServiceReference1.AuthorizeResponse WebClient.ServiceReference1.WebServiceTaxiSoap.Authorize(WebClient.ServiceReference1.AuthorizeRequest request) {
            return base.Channel.Authorize(request);
        }
        
        public System.Guid Authorize(string authorization) {
            WebClient.ServiceReference1.AuthorizeRequest inValue = new WebClient.ServiceReference1.AuthorizeRequest();
            inValue.Body = new WebClient.ServiceReference1.AuthorizeRequestBody();
            inValue.Body.authorization = authorization;
            WebClient.ServiceReference1.AuthorizeResponse retVal = ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).Authorize(inValue);
            return retVal.Body.AuthorizeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.AuthorizeResponse> WebClient.ServiceReference1.WebServiceTaxiSoap.AuthorizeAsync(WebClient.ServiceReference1.AuthorizeRequest request) {
            return base.Channel.AuthorizeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.AuthorizeResponse> AuthorizeAsync(string authorization) {
            WebClient.ServiceReference1.AuthorizeRequest inValue = new WebClient.ServiceReference1.AuthorizeRequest();
            inValue.Body = new WebClient.ServiceReference1.AuthorizeRequestBody();
            inValue.Body.authorization = authorization;
            return ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).AuthorizeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ServiceReference1.GetListOfOrdersResponse WebClient.ServiceReference1.WebServiceTaxiSoap.GetListOfOrders(WebClient.ServiceReference1.GetListOfOrdersRequest request) {
            return base.Channel.GetListOfOrders(request);
        }
        
        public string GetListOfOrders(System.Guid idClient, int role) {
            WebClient.ServiceReference1.GetListOfOrdersRequest inValue = new WebClient.ServiceReference1.GetListOfOrdersRequest();
            inValue.Body = new WebClient.ServiceReference1.GetListOfOrdersRequestBody();
            inValue.Body.idClient = idClient;
            inValue.Body.role = role;
            WebClient.ServiceReference1.GetListOfOrdersResponse retVal = ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).GetListOfOrders(inValue);
            return retVal.Body.GetListOfOrdersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.GetListOfOrdersResponse> WebClient.ServiceReference1.WebServiceTaxiSoap.GetListOfOrdersAsync(WebClient.ServiceReference1.GetListOfOrdersRequest request) {
            return base.Channel.GetListOfOrdersAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.GetListOfOrdersResponse> GetListOfOrdersAsync(System.Guid idClient, int role) {
            WebClient.ServiceReference1.GetListOfOrdersRequest inValue = new WebClient.ServiceReference1.GetListOfOrdersRequest();
            inValue.Body = new WebClient.ServiceReference1.GetListOfOrdersRequestBody();
            inValue.Body.idClient = idClient;
            inValue.Body.role = role;
            return ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).GetListOfOrdersAsync(inValue);
        }
        
        public void GetOrder(System.Guid idDriver, System.Guid idOrder) {
            base.Channel.GetOrder(idDriver, idOrder);
        }
        
        public System.Threading.Tasks.Task GetOrderAsync(System.Guid idDriver, System.Guid idOrder) {
            return base.Channel.GetOrderAsync(idDriver, idOrder);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ServiceReference1.CreateOrderResponse WebClient.ServiceReference1.WebServiceTaxiSoap.CreateOrder(WebClient.ServiceReference1.CreateOrderRequest request) {
            return base.Channel.CreateOrder(request);
        }
        
        public void CreateOrder(string order) {
            WebClient.ServiceReference1.CreateOrderRequest inValue = new WebClient.ServiceReference1.CreateOrderRequest();
            inValue.Body = new WebClient.ServiceReference1.CreateOrderRequestBody();
            inValue.Body.order = order;
            WebClient.ServiceReference1.CreateOrderResponse retVal = ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).CreateOrder(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.CreateOrderResponse> WebClient.ServiceReference1.WebServiceTaxiSoap.CreateOrderAsync(WebClient.ServiceReference1.CreateOrderRequest request) {
            return base.Channel.CreateOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.CreateOrderResponse> CreateOrderAsync(string order) {
            WebClient.ServiceReference1.CreateOrderRequest inValue = new WebClient.ServiceReference1.CreateOrderRequest();
            inValue.Body = new WebClient.ServiceReference1.CreateOrderRequestBody();
            inValue.Body.order = order;
            return ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).CreateOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ServiceReference1.ShowOrderResponse WebClient.ServiceReference1.WebServiceTaxiSoap.ShowOrder(WebClient.ServiceReference1.ShowOrderRequest request) {
            return base.Channel.ShowOrder(request);
        }
        
        public string ShowOrder(System.Guid idClient) {
            WebClient.ServiceReference1.ShowOrderRequest inValue = new WebClient.ServiceReference1.ShowOrderRequest();
            inValue.Body = new WebClient.ServiceReference1.ShowOrderRequestBody();
            inValue.Body.idClient = idClient;
            WebClient.ServiceReference1.ShowOrderResponse retVal = ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).ShowOrder(inValue);
            return retVal.Body.ShowOrderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.ShowOrderResponse> WebClient.ServiceReference1.WebServiceTaxiSoap.ShowOrderAsync(WebClient.ServiceReference1.ShowOrderRequest request) {
            return base.Channel.ShowOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.ShowOrderResponse> ShowOrderAsync(System.Guid idClient) {
            WebClient.ServiceReference1.ShowOrderRequest inValue = new WebClient.ServiceReference1.ShowOrderRequest();
            inValue.Body = new WebClient.ServiceReference1.ShowOrderRequestBody();
            inValue.Body.idClient = idClient;
            return ((WebClient.ServiceReference1.WebServiceTaxiSoap)(this)).ShowOrderAsync(inValue);
        }
        
        public void CancellationOfOrder(System.Guid idClient, System.Guid idOrder) {
            base.Channel.CancellationOfOrder(idClient, idOrder);
        }
        
        public System.Threading.Tasks.Task CancellationOfOrderAsync(System.Guid idClient, System.Guid idOrder) {
            return base.Channel.CancellationOfOrderAsync(idClient, idOrder);
        }
        
        public void StartTrip(System.Guid idDriver, System.Guid idOrder) {
            base.Channel.StartTrip(idDriver, idOrder);
        }
        
        public System.Threading.Tasks.Task StartTripAsync(System.Guid idDriver, System.Guid idOrder) {
            return base.Channel.StartTripAsync(idDriver, idOrder);
        }
        
        public void FinishTrip(System.Guid idDriver, System.Guid idOrder) {
            base.Channel.FinishTrip(idDriver, idOrder);
        }
        
        public System.Threading.Tasks.Task FinishTripAsync(System.Guid idDriver, System.Guid idOrder) {
            return base.Channel.FinishTripAsync(idDriver, idOrder);
        }
    }
}