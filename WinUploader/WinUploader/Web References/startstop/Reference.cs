﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.239.
// 
#pragma warning disable 1591

namespace WinUploader.startstop {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AccessPointSoap", Namespace="http://startstop.me/")]
    public partial class AccessPoint : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LoginUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddStatOverviewOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddUserStatOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AccessPoint() {
            this.Url = global::WinUploader.Properties.Settings.Default.WinUploader_startstop_AccessPoint;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event LoginUserCompletedEventHandler LoginUserCompleted;
        
        /// <remarks/>
        public event AddStatOverviewCompletedEventHandler AddStatOverviewCompleted;
        
        /// <remarks/>
        public event AddUserStatCompletedEventHandler AddUserStatCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://startstop.me/LoginUser", RequestNamespace="http://startstop.me/", ResponseNamespace="http://startstop.me/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ValidatedUserInfo LoginUser(string APIKey, string Username, string Password) {
            object[] results = this.Invoke("LoginUser", new object[] {
                        APIKey,
                        Username,
                        Password});
            return ((ValidatedUserInfo)(results[0]));
        }
        
        /// <remarks/>
        public void LoginUserAsync(string APIKey, string Username, string Password) {
            this.LoginUserAsync(APIKey, Username, Password, null);
        }
        
        /// <remarks/>
        public void LoginUserAsync(string APIKey, string Username, string Password, object userState) {
            if ((this.LoginUserOperationCompleted == null)) {
                this.LoginUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginUserOperationCompleted);
            }
            this.InvokeAsync("LoginUser", new object[] {
                        APIKey,
                        Username,
                        Password}, this.LoginUserOperationCompleted, userState);
        }
        
        private void OnLoginUserOperationCompleted(object arg) {
            if ((this.LoginUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginUserCompleted(this, new LoginUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://startstop.me/AddStatOverview", RequestNamespace="http://startstop.me/", ResponseNamespace="http://startstop.me/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MessageResponse AddStatOverview(string APIKey, StatOverView oStat) {
            object[] results = this.Invoke("AddStatOverview", new object[] {
                        APIKey,
                        oStat});
            return ((MessageResponse)(results[0]));
        }
        
        /// <remarks/>
        public void AddStatOverviewAsync(string APIKey, StatOverView oStat) {
            this.AddStatOverviewAsync(APIKey, oStat, null);
        }
        
        /// <remarks/>
        public void AddStatOverviewAsync(string APIKey, StatOverView oStat, object userState) {
            if ((this.AddStatOverviewOperationCompleted == null)) {
                this.AddStatOverviewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddStatOverviewOperationCompleted);
            }
            this.InvokeAsync("AddStatOverview", new object[] {
                        APIKey,
                        oStat}, this.AddStatOverviewOperationCompleted, userState);
        }
        
        private void OnAddStatOverviewOperationCompleted(object arg) {
            if ((this.AddStatOverviewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddStatOverviewCompleted(this, new AddStatOverviewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://startstop.me/AddUserStat", RequestNamespace="http://startstop.me/", ResponseNamespace="http://startstop.me/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MessageResponse AddUserStat(string APIKey) {
            object[] results = this.Invoke("AddUserStat", new object[] {
                        APIKey});
            return ((MessageResponse)(results[0]));
        }
        
        /// <remarks/>
        public void AddUserStatAsync(string APIKey) {
            this.AddUserStatAsync(APIKey, null);
        }
        
        /// <remarks/>
        public void AddUserStatAsync(string APIKey, object userState) {
            if ((this.AddUserStatOperationCompleted == null)) {
                this.AddUserStatOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddUserStatOperationCompleted);
            }
            this.InvokeAsync("AddUserStat", new object[] {
                        APIKey}, this.AddUserStatOperationCompleted, userState);
        }
        
        private void OnAddUserStatOperationCompleted(object arg) {
            if ((this.AddUserStatCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddUserStatCompleted(this, new AddUserStatCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://startstop.me/")]
    public partial class ValidatedUserInfo {
        
        private bool validatedField;
        
        private System.Guid userGUIDField;
        
        private long userIDField;
        
        private string usernameField;
        
        /// <remarks/>
        public bool Validated {
            get {
                return this.validatedField;
            }
            set {
                this.validatedField = value;
            }
        }
        
        /// <remarks/>
        public System.Guid UserGUID {
            get {
                return this.userGUIDField;
            }
            set {
                this.userGUIDField = value;
            }
        }
        
        /// <remarks/>
        public long UserID {
            get {
                return this.userIDField;
            }
            set {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://startstop.me/")]
    public partial class MessageResponse {
        
        private bool successField;
        
        private long returnIDField;
        
        private System.Guid returnGUIDField;
        
        private string messageField;
        
        /// <remarks/>
        public bool Success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        public long ReturnID {
            get {
                return this.returnIDField;
            }
            set {
                this.returnIDField = value;
            }
        }
        
        /// <remarks/>
        public System.Guid ReturnGUID {
            get {
                return this.returnGUIDField;
            }
            set {
                this.returnGUIDField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://startstop.me/")]
    public partial class StatOverView {
        
        private long overviewIDField;
        
        private string titleField;
        
        private string descriptionField;
        
        private System.DateTime createdOnField;
        
        private System.DateTime modifiedOnField;
        
        /// <remarks/>
        public long OverviewID {
            get {
                return this.overviewIDField;
            }
            set {
                this.overviewIDField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreatedOn {
            get {
                return this.createdOnField;
            }
            set {
                this.createdOnField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ModifiedOn {
            get {
                return this.modifiedOnField;
            }
            set {
                this.modifiedOnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void LoginUserCompletedEventHandler(object sender, LoginUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ValidatedUserInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ValidatedUserInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddStatOverviewCompletedEventHandler(object sender, AddStatOverviewCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddStatOverviewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddStatOverviewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MessageResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MessageResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddUserStatCompletedEventHandler(object sender, AddUserStatCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddUserStatCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddUserStatCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MessageResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MessageResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591