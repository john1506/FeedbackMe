﻿#pragma checksum "c:\users\john\FeedbackMe\src\Feedb\Feedb\Views\Login\LoginRegistrationWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C1895807CDE72ECAF4B4FEE0B87F30D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Feedb.LoginUI;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Feedb.LoginUI {
    
    
    public partial class LoginRegistrationWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.ChildWindow childWindow;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Feedb.LoginUI.LoginForm loginForm;
        
        internal Feedb.LoginUI.RegistrationForm registrationForm;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Feedb;component/Views/Login/LoginRegistrationWindow.xaml", System.UriKind.Relative));
            this.childWindow = ((System.Windows.Controls.ChildWindow)(this.FindName("childWindow")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.loginForm = ((Feedb.LoginUI.LoginForm)(this.FindName("loginForm")));
            this.registrationForm = ((Feedb.LoginUI.RegistrationForm)(this.FindName("registrationForm")));
        }
    }
}

