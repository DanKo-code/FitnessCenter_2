﻿#pragma checksum "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1CBDB72633570BCA7F27502D828541B426C9D44D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FitnessCenter.Converters;
using FitnessCenter.Helpers;
using FitnessCenter.ViewModel;
using FitnessCenter.Views.Windows.Main;
using FitnessCenter.Views.Windows.Main.UserControls.Abonements;
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


namespace FitnessCenter.Views.Windows.Main {
    
    
    /// <summary>
    /// MainCoreD
    /// </summary>
    public partial class MainCoreD : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FitnessCenter.Views.Windows.Main.MainCoreD MainWinCore;
        
        #line default
        #line hidden
        
        
        #line 359 "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image collapsImg;
        
        #line default
        #line hidden
        
        
        #line 374 "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image closeImg;
        
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
            System.Uri resourceLocater = new System.Uri("/FitnessCenter;component/views/windows/main/maincored.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml"
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
            this.MainWinCore = ((FitnessCenter.Views.Windows.Main.MainCoreD)(target));
            return;
            case 2:
            
            #line 321 "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            
            #line 321 "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.collapsImg = ((System.Windows.Controls.Image)(target));
            
            #line 360 "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml"
            this.collapsImg.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.collapsImg_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.closeImg = ((System.Windows.Controls.Image)(target));
            
            #line 375 "..\..\..\..\..\..\Views\Windows\Main\MainCoreD.xaml"
            this.closeImg.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.closeImg_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
