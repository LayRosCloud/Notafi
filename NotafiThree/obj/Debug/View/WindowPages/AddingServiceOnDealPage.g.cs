﻿#pragma checksum "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ECB400DC5974E27E7639E8484B8359D7160FEEA9EA4E5731DC9FD8447B21686A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NotafiThree.View.WindowPages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace NotafiThree.View.WindowPages {
    
    
    /// <summary>
    /// AddingServiceOnDealPage
    /// </summary>
    public partial class AddingServiceOnDealPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox services;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock title;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock description;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock price;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock discount;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock typeDoc;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox number;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NotafiThree;component/view/windowpages/addingserviceondealpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.services = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
            this.services.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.services_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.price = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.discount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.typeDoc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.number = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 53 "..\..\..\..\View\WindowPages\AddingServiceOnDealPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddServiceToDeal);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

