#pragma checksum "..\..\Filtering.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2BEEF4481FBC664777BED7AA513E880C0F1FC3341DBF6E5234F7C28FA49D214B"
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace DBApp {
    
    
    /// <summary>
    /// Filtering
    /// </summary>
    public partial class Filtering : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Columns;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox Box;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DoNotSort;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SortAscending;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SortDescending;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton IncludeString;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ExcludeString;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton NumberGreater;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton NumberSmaller;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton NotEqual;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Equal;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton isNull;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox StringFilterBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox NumberFilterBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Filtering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyFilter;
        
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
            System.Uri resourceLocater = new System.Uri("/DBApp;component/filtering.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Filtering.xaml"
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
            
            #line 9 "..\..\Filtering.xaml"
            ((DBApp.Filtering)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Filtering_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Columns = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\Filtering.xaml"
            this.Columns.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Columns_OnSelectionChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\Filtering.xaml"
            this.Columns.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Columns_OnMouseEnter);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Box = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 4:
            this.DoNotSort = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.SortAscending = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.SortDescending = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.IncludeString = ((System.Windows.Controls.RadioButton)(target));
            
            #line 20 "..\..\Filtering.xaml"
            this.IncludeString.Click += new System.Windows.RoutedEventHandler(this.IncludeString_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ExcludeString = ((System.Windows.Controls.RadioButton)(target));
            
            #line 21 "..\..\Filtering.xaml"
            this.ExcludeString.Click += new System.Windows.RoutedEventHandler(this.IncludeString_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NumberGreater = ((System.Windows.Controls.RadioButton)(target));
            
            #line 22 "..\..\Filtering.xaml"
            this.NumberGreater.Click += new System.Windows.RoutedEventHandler(this.NumberGreater_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.NumberSmaller = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\Filtering.xaml"
            this.NumberSmaller.Click += new System.Windows.RoutedEventHandler(this.NumberGreater_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.NotEqual = ((System.Windows.Controls.RadioButton)(target));
            
            #line 24 "..\..\Filtering.xaml"
            this.NotEqual.Click += new System.Windows.RoutedEventHandler(this.NumberGreater_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Equal = ((System.Windows.Controls.RadioButton)(target));
            
            #line 25 "..\..\Filtering.xaml"
            this.Equal.Click += new System.Windows.RoutedEventHandler(this.NumberGreater_OnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.isNull = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 14:
            this.StringFilterBox = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            return;
            case 15:
            this.NumberFilterBox = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            return;
            case 16:
            this.ApplyFilter = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Filtering.xaml"
            this.ApplyFilter.Click += new System.Windows.RoutedEventHandler(this.ApplyFilter_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

