﻿#pragma checksum "..\..\DynamicGrid.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "36C0D3805B5E6CA49D6EBE73971B0FCE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
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


namespace Chapter6 {
    
    
    /// <summary>
    /// DynamicGrid
    /// </summary>
    public partial class DynamicGrid : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\DynamicGrid.xaml"
        internal System.Windows.Controls.Grid Grid1;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\DynamicGrid.xaml"
        internal System.Windows.Controls.Button cmdIterateChildren;
        
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
            System.Uri resourceLocater = new System.Uri("/Chapter6;component/dynamicgrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DynamicGrid.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\DynamicGrid.xaml"
            ((Chapter6.DynamicGrid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.cmdIterateChildren = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\DynamicGrid.xaml"
            this.cmdIterateChildren.Click += new System.Windows.RoutedEventHandler(this.cmdGetData_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}