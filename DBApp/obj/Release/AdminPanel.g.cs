﻿#pragma checksum "..\..\AdminPanel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9397D2E8A6D71470040D8DF828E959A74037D8F18FB5D2618A8E9F0DA4922BC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DBApp;
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


namespace DBApp {
    
    
    /// <summary>
    /// AdminPanel
    /// </summary>
    public partial class AdminPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 11 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Tables;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEntry;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Filter;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteEntry;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\AdminPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Table;
        
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
            System.Uri resourceLocater = new System.Uri("/DBApp;component/adminpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminPanel.xaml"
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
            this.Tables = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\AdminPanel.xaml"
            this.Tables.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Tables_OnSelectionChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\AdminPanel.xaml"
            this.Tables.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Tables_OnMouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddEntry = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\AdminPanel.xaml"
            this.AddEntry.Click += new System.Windows.RoutedEventHandler(this.AddEntry_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Filter = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\AdminPanel.xaml"
            this.Filter.Click += new System.Windows.RoutedEventHandler(this.Filter_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteEntry = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\AdminPanel.xaml"
            this.DeleteEntry.Click += new System.Windows.RoutedEventHandler(this.DeleteEntry_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Table = ((System.Windows.Controls.DataGrid)(target));
            
            #line 103 "..\..\AdminPanel.xaml"
            this.Table.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Table_OnMouseDoubleClick);
            
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
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 6:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 106 "..\..\AdminPanel.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DataGridCell_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}
