﻿#pragma checksum "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7DBFFAF16039766376E77AC08CE5D5CDFEB3B387"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FitnessCenter.Views.Windows.LoginRegistration.UserControls;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
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


namespace FitnessCenter.Views.Windows.LoginRegistration.UserControls {
    
    
    /// <summary>
    /// LoginD
    /// </summary>
    public partial class LoginD : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image loginImg;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image passImg;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image eyeImg;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RegButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FitnessCenter;component/views/windows/loginregistration/usercontrols/logind.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.loginImg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.loginBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.loginBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.loginBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passImg = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.textBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus_1);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.textBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 49 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.passwordBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus_1);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.passwordBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.eyeImg = ((System.Windows.Controls.Image)(target));
            
            #line 52 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.eyeImg.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.eyeImg_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RegButton = ((System.Windows.Controls.TextBlock)(target));
            
            #line 72 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.RegButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Grid_MouseEnter);
            
            #line default
            #line hidden
            
            #line 74 "..\..\..\..\..\..\..\Views\Windows\LoginRegistration\UserControls\LoginD.xaml"
            this.RegButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.RegButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

