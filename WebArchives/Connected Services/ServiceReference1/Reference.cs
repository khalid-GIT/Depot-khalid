﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebArchives.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tbl_Client", Namespace="http://schemas.datacontract.org/2004/07/DAL.Entity")]
    [System.SerializableAttribute()]
    public partial class Tbl_Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdresseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CnssField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodePostalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DatedeCreationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GsmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdFamilleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdVilleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebArchives.ServiceReference1.Tbl_Contact_Clt Tbl_Contact_CltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebArchives.ServiceReference1.Tbl_Famille_Clt Tbl_Famille_CltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebArchives.ServiceReference1.Tbl_Ville Tbl_VilleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string faxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telephone1Field;
        
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
        public string Adresse {
            get {
                return this.AdresseField;
            }
            set {
                if ((object.ReferenceEquals(this.AdresseField, value) != true)) {
                    this.AdresseField = value;
                    this.RaisePropertyChanged("Adresse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cnss {
            get {
                return this.CnssField;
            }
            set {
                if ((object.ReferenceEquals(this.CnssField, value) != true)) {
                    this.CnssField = value;
                    this.RaisePropertyChanged("Cnss");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodePostal {
            get {
                return this.CodePostalField;
            }
            set {
                if ((object.ReferenceEquals(this.CodePostalField, value) != true)) {
                    this.CodePostalField = value;
                    this.RaisePropertyChanged("CodePostal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DatedeCreation {
            get {
                return this.DatedeCreationField;
            }
            set {
                if ((this.DatedeCreationField.Equals(value) != true)) {
                    this.DatedeCreationField = value;
                    this.RaisePropertyChanged("DatedeCreation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gsm {
            get {
                return this.GsmField;
            }
            set {
                if ((object.ReferenceEquals(this.GsmField, value) != true)) {
                    this.GsmField = value;
                    this.RaisePropertyChanged("Gsm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDContact {
            get {
                return this.IDContactField;
            }
            set {
                if ((this.IDContactField.Equals(value) != true)) {
                    this.IDContactField = value;
                    this.RaisePropertyChanged("IDContact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ice {
            get {
                return this.IceField;
            }
            set {
                if ((object.ReferenceEquals(this.IceField, value) != true)) {
                    this.IceField = value;
                    this.RaisePropertyChanged("Ice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdFamille {
            get {
                return this.IdFamilleField;
            }
            set {
                if ((this.IdFamilleField.Equals(value) != true)) {
                    this.IdFamilleField = value;
                    this.RaisePropertyChanged("IdFamille");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdVille {
            get {
                return this.IdVilleField;
            }
            set {
                if ((this.IdVilleField.Equals(value) != true)) {
                    this.IdVilleField = value;
                    this.RaisePropertyChanged("IdVille");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mail {
            get {
                return this.MailField;
            }
            set {
                if ((object.ReferenceEquals(this.MailField, value) != true)) {
                    this.MailField = value;
                    this.RaisePropertyChanged("Mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebArchives.ServiceReference1.Tbl_Contact_Clt Tbl_Contact_Clt {
            get {
                return this.Tbl_Contact_CltField;
            }
            set {
                if ((object.ReferenceEquals(this.Tbl_Contact_CltField, value) != true)) {
                    this.Tbl_Contact_CltField = value;
                    this.RaisePropertyChanged("Tbl_Contact_Clt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebArchives.ServiceReference1.Tbl_Famille_Clt Tbl_Famille_Clt {
            get {
                return this.Tbl_Famille_CltField;
            }
            set {
                if ((object.ReferenceEquals(this.Tbl_Famille_CltField, value) != true)) {
                    this.Tbl_Famille_CltField = value;
                    this.RaisePropertyChanged("Tbl_Famille_Clt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebArchives.ServiceReference1.Tbl_Ville Tbl_Ville {
            get {
                return this.Tbl_VilleField;
            }
            set {
                if ((object.ReferenceEquals(this.Tbl_VilleField, value) != true)) {
                    this.Tbl_VilleField = value;
                    this.RaisePropertyChanged("Tbl_Ville");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Teleph {
            get {
                return this.TelephField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephField, value) != true)) {
                    this.TelephField = value;
                    this.RaisePropertyChanged("Teleph");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fax {
            get {
                return this.faxField;
            }
            set {
                if ((object.ReferenceEquals(this.faxField, value) != true)) {
                    this.faxField = value;
                    this.RaisePropertyChanged("fax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idf {
            get {
                return this.idfField;
            }
            set {
                if ((object.ReferenceEquals(this.idfField, value) != true)) {
                    this.idfField = value;
                    this.RaisePropertyChanged("idf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telephone1 {
            get {
                return this.telephone1Field;
            }
            set {
                if ((object.ReferenceEquals(this.telephone1Field, value) != true)) {
                    this.telephone1Field = value;
                    this.RaisePropertyChanged("telephone1");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tbl_Contact_Clt", Namespace="http://schemas.datacontract.org/2004/07/DAL.Entity")]
    [System.SerializableAttribute()]
    public partial class Tbl_Contact_Clt : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GsmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDServiceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebArchives.ServiceReference1.Tbl_Client[] Tbl_ClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebArchives.ServiceReference1.Tbl_Service Tbl_ServiceField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gsm {
            get {
                return this.GsmField;
            }
            set {
                if ((object.ReferenceEquals(this.GsmField, value) != true)) {
                    this.GsmField = value;
                    this.RaisePropertyChanged("Gsm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDContact {
            get {
                return this.IDContactField;
            }
            set {
                if ((this.IDContactField.Equals(value) != true)) {
                    this.IDContactField = value;
                    this.RaisePropertyChanged("IDContact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDService {
            get {
                return this.IDServiceField;
            }
            set {
                if ((this.IDServiceField.Equals(value) != true)) {
                    this.IDServiceField = value;
                    this.RaisePropertyChanged("IDService");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom {
            get {
                return this.PrenomField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenomField, value) != true)) {
                    this.PrenomField = value;
                    this.RaisePropertyChanged("Prenom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebArchives.ServiceReference1.Tbl_Client[] Tbl_Client {
            get {
                return this.Tbl_ClientField;
            }
            set {
                if ((object.ReferenceEquals(this.Tbl_ClientField, value) != true)) {
                    this.Tbl_ClientField = value;
                    this.RaisePropertyChanged("Tbl_Client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebArchives.ServiceReference1.Tbl_Service Tbl_Service {
            get {
                return this.Tbl_ServiceField;
            }
            set {
                if ((object.ReferenceEquals(this.Tbl_ServiceField, value) != true)) {
                    this.Tbl_ServiceField = value;
                    this.RaisePropertyChanged("Tbl_Service");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tbl_Famille_Clt", Namespace="http://schemas.datacontract.org/2004/07/DAL.Entity")]
    [System.SerializableAttribute()]
    public partial class Tbl_Famille_Clt : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdFamilleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LibelleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebArchives.ServiceReference1.Tbl_Client[] Tbl_ClientField;
        
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
        public int IdFamille {
            get {
                return this.IdFamilleField;
            }
            set {
                if ((this.IdFamilleField.Equals(value) != true)) {
                    this.IdFamilleField = value;
                    this.RaisePropertyChanged("IdFamille");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Libelle {
            get {
                return this.LibelleField;
            }
            set {
                if ((object.ReferenceEquals(this.LibelleField, value) != true)) {
                    this.LibelleField = value;
                    this.RaisePropertyChanged("Libelle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebArchives.ServiceReference1.Tbl_Client[] Tbl_Client {
            get {
                return this.Tbl_ClientField;
            }
            set {
                if ((object.ReferenceEquals(this.Tbl_ClientField, value) != true)) {
                    this.Tbl_ClientField = value;
                    this.RaisePropertyChanged("Tbl_Client");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tbl_Ville", Namespace="http://schemas.datacontract.org/2004/07/DAL.Entity")]
    [System.SerializableAttribute()]
    public partial class Tbl_Ville : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdVilleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebArchives.ServiceReference1.Tbl_Client[] Tbl_ClientsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string libelleField;
        
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
        public int IdVille {
            get {
                return this.IdVilleField;
            }
            set {
                if ((this.IdVilleField.Equals(value) != true)) {
                    this.IdVilleField = value;
                    this.RaisePropertyChanged("IdVille");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebArchives.ServiceReference1.Tbl_Client[] Tbl_Clients {
            get {
                return this.Tbl_ClientsField;
            }
            set {
                if ((object.ReferenceEquals(this.Tbl_ClientsField, value) != true)) {
                    this.Tbl_ClientsField = value;
                    this.RaisePropertyChanged("Tbl_Clients");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string libelle {
            get {
                return this.libelleField;
            }
            set {
                if ((object.ReferenceEquals(this.libelleField, value) != true)) {
                    this.libelleField = value;
                    this.RaisePropertyChanged("libelle");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tbl_Service", Namespace="http://schemas.datacontract.org/2004/07/DAL.Entity")]
    [System.SerializableAttribute()]
    public partial class Tbl_Service : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDServiceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebArchives.ServiceReference1.Tbl_Contact_Clt[] Tbl_Contact_ClitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string libelleField;
        
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
        public int IDService {
            get {
                return this.IDServiceField;
            }
            set {
                if ((this.IDServiceField.Equals(value) != true)) {
                    this.IDServiceField = value;
                    this.RaisePropertyChanged("IDService");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebArchives.ServiceReference1.Tbl_Contact_Clt[] Tbl_Contact_Clit {
            get {
                return this.Tbl_Contact_ClitField;
            }
            set {
                if ((object.ReferenceEquals(this.Tbl_Contact_ClitField, value) != true)) {
                    this.Tbl_Contact_ClitField = value;
                    this.RaisePropertyChanged("Tbl_Contact_Clit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string libelle {
            get {
                return this.libelleField;
            }
            set {
                if ((object.ReferenceEquals(this.libelleField, value) != true)) {
                    this.libelleField = value;
                    this.RaisePropertyChanged("libelle");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceClients")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClients", ReplyAction="http://tempuri.org/IService1/GetClientsResponse")]
        WebArchives.ServiceReference1.Tbl_Client[] GetClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClients", ReplyAction="http://tempuri.org/IService1/GetClientsResponse")]
        System.Threading.Tasks.Task<WebArchives.ServiceReference1.Tbl_Client[]> GetClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WebArchives.ServiceReference1.CompositeType GetDataUsingDataContract(WebArchives.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebArchives.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WebArchives.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebArchives.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebArchives.ServiceReference1.IService1>, WebArchives.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WebArchives.ServiceReference1.Tbl_Client[] GetClients() {
            return base.Channel.GetClients();
        }
        
        public System.Threading.Tasks.Task<WebArchives.ServiceReference1.Tbl_Client[]> GetClientsAsync() {
            return base.Channel.GetClientsAsync();
        }
        
        public WebArchives.ServiceReference1.CompositeType GetDataUsingDataContract(WebArchives.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WebArchives.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WebArchives.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
