﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consumir.ServiceOwncloud {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="oc_users", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class oc_users : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string displaynameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string uidField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string displayname {
            get {
                return this.displaynameField;
            }
            set {
                if ((object.ReferenceEquals(this.displaynameField, value) != true)) {
                    this.displaynameField = value;
                    this.RaisePropertyChanged("displayname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string uid {
            get {
                return this.uidField;
            }
            set {
                if ((object.ReferenceEquals(this.uidField, value) != true)) {
                    this.uidField = value;
                    this.RaisePropertyChanged("uid");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceOwncloud.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/create", ReplyAction="http://tempuri.org/IService1/createResponse")]
        consumir.ServiceOwncloud.oc_users create(consumir.ServiceOwncloud.oc_users entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/create", ReplyAction="http://tempuri.org/IService1/createResponse")]
        System.Threading.Tasks.Task<consumir.ServiceOwncloud.oc_users> createAsync(consumir.ServiceOwncloud.oc_users entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/update", ReplyAction="http://tempuri.org/IService1/updateResponse")]
        consumir.ServiceOwncloud.oc_users update(consumir.ServiceOwncloud.oc_users entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/update", ReplyAction="http://tempuri.org/IService1/updateResponse")]
        System.Threading.Tasks.Task<consumir.ServiceOwncloud.oc_users> updateAsync(consumir.ServiceOwncloud.oc_users entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/delete", ReplyAction="http://tempuri.org/IService1/deleteResponse")]
        int delete(string uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/delete", ReplyAction="http://tempuri.org/IService1/deleteResponse")]
        System.Threading.Tasks.Task<int> deleteAsync(string uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/list", ReplyAction="http://tempuri.org/IService1/listResponse")]
        consumir.ServiceOwncloud.oc_users[] list();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/list", ReplyAction="http://tempuri.org/IService1/listResponse")]
        System.Threading.Tasks.Task<consumir.ServiceOwncloud.oc_users[]> listAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : consumir.ServiceOwncloud.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<consumir.ServiceOwncloud.IService1>, consumir.ServiceOwncloud.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public consumir.ServiceOwncloud.oc_users create(consumir.ServiceOwncloud.oc_users entity) {
            return base.Channel.create(entity);
        }
        
        public System.Threading.Tasks.Task<consumir.ServiceOwncloud.oc_users> createAsync(consumir.ServiceOwncloud.oc_users entity) {
            return base.Channel.createAsync(entity);
        }
        
        public consumir.ServiceOwncloud.oc_users update(consumir.ServiceOwncloud.oc_users entity) {
            return base.Channel.update(entity);
        }
        
        public System.Threading.Tasks.Task<consumir.ServiceOwncloud.oc_users> updateAsync(consumir.ServiceOwncloud.oc_users entity) {
            return base.Channel.updateAsync(entity);
        }
        
        public int delete(string uid) {
            return base.Channel.delete(uid);
        }
        
        public System.Threading.Tasks.Task<int> deleteAsync(string uid) {
            return base.Channel.deleteAsync(uid);
        }
        
        public consumir.ServiceOwncloud.oc_users[] list() {
            return base.Channel.list();
        }
        
        public System.Threading.Tasks.Task<consumir.ServiceOwncloud.oc_users[]> listAsync() {
            return base.Channel.listAsync();
        }
    }
}
