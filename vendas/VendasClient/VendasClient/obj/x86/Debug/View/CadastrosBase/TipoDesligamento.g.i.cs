﻿#pragma checksum "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0BA21F9FCA2591C0142849D965D28F68"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace CadastrosBaseClient.View.CadastrosBase {
    
    
    /// <summary>
    /// TipoDesligamento
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class TipoDesligamento : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalvar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSair;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCodigo;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDescricao;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCodigo;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescricao;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/VendasClient;component/view/cadastrosbase/tipodesligamento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnSalvar = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
            this.btnSalvar.Click += new System.Windows.RoutedEventHandler(this.btnSalvar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSair = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\View\CadastrosBase\TipoDesligamento.xaml"
            this.btnSair.Click += new System.Windows.RoutedEventHandler(this.btnSair_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblCodigo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblDescricao = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtCodigo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDescricao = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

