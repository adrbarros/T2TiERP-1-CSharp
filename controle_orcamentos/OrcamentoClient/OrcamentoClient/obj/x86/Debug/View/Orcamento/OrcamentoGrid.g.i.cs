﻿#pragma checksum "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D5156EFBAB267470C556435372B7E4FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExportarParaArquivo;
using ExportarParaArquivo.Control;
using OrcamentoClient.Util;
using OrcamentoClient.ViewModel.Orcamento;
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


namespace OrcamentoClient.View.Orcamento {
    
    
    /// <summary>
    /// OrcamentoGrid
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class OrcamentoGrid : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboExp;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btNovo;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConsultarOrcamentoDetalhe;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/OrcamentoClient;component/view/orcamento/orcamentogrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml"
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
            this.comboExp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            
            #line 38 "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml"
            ((ExportarParaArquivo.Control.ButtonExport)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonExport_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btNovo = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml"
            this.btNovo.Click += new System.Windows.RoutedEventHandler(this.btNovo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btConsultarOrcamentoDetalhe = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\View\Orcamento\OrcamentoGrid.xaml"
            this.btConsultarOrcamentoDetalhe.Click += new System.Windows.RoutedEventHandler(this.btConsultarOrcamentoDetalhe_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

