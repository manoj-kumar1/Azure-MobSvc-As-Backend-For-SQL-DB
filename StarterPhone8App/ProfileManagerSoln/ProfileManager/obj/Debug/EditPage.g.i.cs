﻿#pragma checksum "C:\Manoj\AzureArticlesSourceCode\StarterPhone8App\ProfileManagerSoln\ProfileManager\EditPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3DC95439C3EADC63C46F47B9B7BFD485"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace ProfileManager {
    
    
    public partial class EditPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBox txtName;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtPhone;
        
        internal System.Windows.Controls.Grid ContentPanel2;
        
        internal System.Windows.Controls.TextBox txtEmail;
        
        internal System.Windows.Controls.Grid ContentPanel3;
        
        internal System.Windows.Controls.Button saveBtn;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ProfileManager;component/EditPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.txtName = ((System.Windows.Controls.TextBox)(this.FindName("txtName")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtPhone = ((System.Windows.Controls.TextBox)(this.FindName("txtPhone")));
            this.ContentPanel2 = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel2")));
            this.txtEmail = ((System.Windows.Controls.TextBox)(this.FindName("txtEmail")));
            this.ContentPanel3 = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel3")));
            this.saveBtn = ((System.Windows.Controls.Button)(this.FindName("saveBtn")));
        }
    }
}

