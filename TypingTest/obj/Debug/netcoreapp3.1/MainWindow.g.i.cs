﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E461F584858E4EE772F2348BEEB1E83F1A951F02"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Controls.Ribbon;
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
using TypingTest;
using TypingTest.ViewModel;


namespace TypingTest {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbKeysInfo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bHideShow;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bConfirm;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtbInfo;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTypingField;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TypingTest;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbKeysInfo = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.bHideShow = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\MainWindow.xaml"
            this.bHideShow.Click += new System.Windows.RoutedEventHandler(this.cHideShowClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\MainWindow.xaml"
            this.bConfirm.Click += new System.Windows.RoutedEventHandler(this.cConfirmResult);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtbInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tbTypingField = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.tbTypingField.KeyUp += new System.Windows.Input.KeyEventHandler(this.OnKeyUpHandler);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.tbTypingField.KeyDown += new System.Windows.Input.KeyEventHandler(this.OnKeyDownHandler);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.tbTypingField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChangedHandler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

