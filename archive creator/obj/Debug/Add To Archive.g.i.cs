﻿#pragma checksum "..\..\Add To Archive.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3821B2225182F64AECD32FF3722E8EFE28F506D2911225CCD55D992B94AED5F"
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
using archive_creator;


namespace archive_creator {
    
    
    /// <summary>
    /// Add_To_Archive
    /// </summary>
    public partial class Add_To_Archive : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Add To Archive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal archive_creator.Add_To_Archive ArchiveForm;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Add To Archive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ArchivePath;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Add To Archive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DestinationPath;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Add To Archive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchDirSourcePath;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Add To Archive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchDirDestinationPath;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Add To Archive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Create_Archive;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Add To Archive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbCompresiontype;
        
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
            System.Uri resourceLocater = new System.Uri("/archive creator;component/add%20to%20archive.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Add To Archive.xaml"
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
            this.ArchiveForm = ((archive_creator.Add_To_Archive)(target));
            return;
            case 2:
            this.ArchivePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DestinationPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SearchDirSourcePath = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Add To Archive.xaml"
            this.SearchDirSourcePath.Click += new System.Windows.RoutedEventHandler(this.SearchDirSourcePath_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchDirDestinationPath = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Add To Archive.xaml"
            this.SearchDirDestinationPath.Click += new System.Windows.RoutedEventHandler(this.SearchDirDestinationPath_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Create_Archive = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Add To Archive.xaml"
            this.Create_Archive.Click += new System.Windows.RoutedEventHandler(this.Create_Archive_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CbCompresiontype = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\Add To Archive.xaml"
            this.CbCompresiontype.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbCompresiontype_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

