﻿#pragma checksum "..\..\..\..\..\..\Objects\Pages\Add_Type\New_Plate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B71F11C820A8FD283D3D06A3556355B5646CB43C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Kurs_v3.Objects.Pages.Add_Type;
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


namespace Kurs_v3.Objects.Pages.Add_Type {
    
    
    /// <summary>
    /// New_Plate
    /// </summary>
    public partial class New_Plate : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\..\Objects\Pages\Add_Type\New_Plate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name_Plate_Text;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\..\Objects\Pages\Add_Type\New_Plate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Serial_number_Plate_text;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\..\Objects\Pages\Add_Type\New_Plate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Plate_Add_Btn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Kurs v3;component/objects/pages/add_type/new_plate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Objects\Pages\Add_Type\New_Plate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Name_Plate_Text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Serial_number_Plate_text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Plate_Add_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\..\..\Objects\Pages\Add_Type\New_Plate.xaml"
            this.Plate_Add_Btn.Click += new System.Windows.RoutedEventHandler(this.Plate_Add_Btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

