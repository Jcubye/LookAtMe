﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaNegocio.ServiceDepartamento {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Departamento", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Departamento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceDepartamento.WebServiceDepartamentoSoap")]
    public interface WebServiceDepartamentoSoap {
        
        // CODEGEN: Generating message contract since element name departamento from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarDepartamentoService", ReplyAction="*")]
        CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceResponse insertarDepartamentoService(CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarDepartamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceResponse> insertarDepartamentoServiceAsync(CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertarDepartamentoServiceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertarDepartamentoService", Namespace="http://tempuri.org/", Order=0)]
        public CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequestBody Body;
        
        public insertarDepartamentoServiceRequest() {
        }
        
        public insertarDepartamentoServiceRequest(CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertarDepartamentoServiceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaNegocio.ServiceDepartamento.Departamento departamento;
        
        public insertarDepartamentoServiceRequestBody() {
        }
        
        public insertarDepartamentoServiceRequestBody(CapaNegocio.ServiceDepartamento.Departamento departamento) {
            this.departamento = departamento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertarDepartamentoServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertarDepartamentoServiceResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceResponseBody Body;
        
        public insertarDepartamentoServiceResponse() {
        }
        
        public insertarDepartamentoServiceResponse(CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class insertarDepartamentoServiceResponseBody {
        
        public insertarDepartamentoServiceResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceDepartamentoSoapChannel : CapaNegocio.ServiceDepartamento.WebServiceDepartamentoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceDepartamentoSoapClient : System.ServiceModel.ClientBase<CapaNegocio.ServiceDepartamento.WebServiceDepartamentoSoap>, CapaNegocio.ServiceDepartamento.WebServiceDepartamentoSoap {
        
        public WebServiceDepartamentoSoapClient() {
        }
        
        public WebServiceDepartamentoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceDepartamentoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceDepartamentoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceDepartamentoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceResponse CapaNegocio.ServiceDepartamento.WebServiceDepartamentoSoap.insertarDepartamentoService(CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequest request) {
            return base.Channel.insertarDepartamentoService(request);
        }
        
        public void insertarDepartamentoService(CapaNegocio.ServiceDepartamento.Departamento departamento) {
            CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequest inValue = new CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequest();
            inValue.Body = new CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequestBody();
            inValue.Body.departamento = departamento;
            CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceResponse retVal = ((CapaNegocio.ServiceDepartamento.WebServiceDepartamentoSoap)(this)).insertarDepartamentoService(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceResponse> CapaNegocio.ServiceDepartamento.WebServiceDepartamentoSoap.insertarDepartamentoServiceAsync(CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequest request) {
            return base.Channel.insertarDepartamentoServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceResponse> insertarDepartamentoServiceAsync(CapaNegocio.ServiceDepartamento.Departamento departamento) {
            CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequest inValue = new CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequest();
            inValue.Body = new CapaNegocio.ServiceDepartamento.insertarDepartamentoServiceRequestBody();
            inValue.Body.departamento = departamento;
            return ((CapaNegocio.ServiceDepartamento.WebServiceDepartamentoSoap)(this)).insertarDepartamentoServiceAsync(inValue);
        }
    }
}