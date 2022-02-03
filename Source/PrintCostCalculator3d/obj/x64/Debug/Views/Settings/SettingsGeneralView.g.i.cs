﻿#pragma checksum "..\..\..\..\..\Views\Settings\SettingsGeneralView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "931B7CF9359186752C91A3762C15A63E80DDC80F30FE3AD3D243BF27D0A32C43"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using PrintCostCalculator3d;
using PrintCostCalculator3d.Converters;
using PrintCostCalculator3d.Resources.Localization;
using PrintCostCalculator3d.Validators;
using PrintCostCalculator3d.ViewModels;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace PrintCostCalculator3d.Views {
    
    
    /// <summary>
    /// SettingsGeneralView
    /// </summary>
    public partial class SettingsGeneralView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 150 "..\..\..\..\..\Views\Settings\SettingsGeneralView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCultures;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\..\Views\Settings\SettingsGeneralView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSelectedCultureName;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\..\Views\Settings\SettingsGeneralView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNewCurrencySymbol;
        
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
            System.Uri resourceLocater = new System.Uri("/3dPrintCostCalculator2;component/views/settings/settingsgeneralview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Settings\SettingsGeneralView.xaml"
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
            
            #line 58 "..\..\..\..\..\Views\Settings\SettingsGeneralView.xaml"
            ((System.Windows.Controls.ListBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxVisibleToHide_OnMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 102 "..\..\..\..\..\Views\Settings\SettingsGeneralView.xaml"
            ((System.Windows.Controls.ListBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxHideToVisible_OnMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbCultures = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.tbSelectedCultureName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbNewCurrencySymbol = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

