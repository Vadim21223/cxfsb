﻿#pragma checksum "..\..\..\Pages\Spravoch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07AB081FBA9B3587159642245DB591AC15455BFC295FFD706F0A66D0E110DCF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Mez01.Pages;
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


namespace Mez01.Pages {
    
    
    /// <summary>
    /// Spravoch
    /// </summary>
    public partial class Spravoch : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 12 "..\..\..\Pages\Spravoch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView InformationLV;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\Spravoch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\Spravoch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\Spravoch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefrBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\Spravoch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\Spravoch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox poiskTbx;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\Spravoch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filtrTbx;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\Spravoch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortCmb;
        
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
            System.Uri resourceLocater = new System.Uri("/Mez01;component/pages/spravoch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Spravoch.xaml"
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
            this.InformationLV = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\Spravoch.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\Spravoch.xaml"
            this.DelBtn.Click += new System.Windows.RoutedEventHandler(this.DelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RefrBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\Spravoch.xaml"
            this.RefrBtn.Click += new System.Windows.RoutedEventHandler(this.RefrBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\Spravoch.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.poiskTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Pages\Spravoch.xaml"
            this.poiskTbx.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.poiskTbx_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.filtrTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Pages\Spravoch.xaml"
            this.filtrTbx.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.filtrTbx_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.sortCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\Pages\Spravoch.xaml"
            this.sortCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sortCmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 20 "..\..\..\Pages\Spravoch.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

