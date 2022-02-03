﻿#pragma checksum "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25564668392CB753A4D1836F55F0A78D9FAF46126F5E8508CDC92400CFE2D0E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AndreasReitberger.Enums;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using PrintCostCalculator3d;
using PrintCostCalculator3d.Controls;
using PrintCostCalculator3d.Converters;
using PrintCostCalculator3d.Resources.Localization;
using PrintCostCalculator3d.Templates;
using PrintCostCalculator3d.Validators;
using PrintCostCalculator3d.ViewModels.Dashboard;
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


namespace PrintCostCalculator3d.Views.Dashboard {
    
    
    /// <summary>
    /// DashboardCalculatorView
    /// </summary>
    public partial class DashboardCalculatorView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 107 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCalculation;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 380 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglGeneralEnergyCosts;
        
        #line default
        #line hidden
        
        
        #line 385 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbkApplyEnergyCosts;
        
        #line default
        #line hidden
        
        
        #line 479 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglGeneralTaxRate;
        
        #line default
        #line hidden
        
        
        #line 484 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbApplyTaxes;
        
        #line default
        #line hidden
        
        
        #line 504 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudTaxRate;
        
        #line default
        #line hidden
        
        
        #line 587 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglAdvancedMarginSettings;
        
        #line default
        #line hidden
        
        
        #line 592 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbApplyAdvancedMarginSettings;
        
        #line default
        #line hidden
        
        
        #line 706 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbProcedureSpecificAdditions;
        
        #line default
        #line hidden
        
        
        #line 850 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglNozzleWear;
        
        #line default
        #line hidden
        
        
        #line 855 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbFilamentApplyNozzleWearCosts;
        
        #line default
        #line hidden
        
        
        #line 929 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglPrintSheetWear;
        
        #line default
        #line hidden
        
        
        #line 934 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbFilamentApplyPrintSheetWearCosts;
        
        #line default
        #line hidden
        
        
        #line 1012 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglGloves;
        
        #line default
        #line hidden
        
        
        #line 1017 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbResinApplyGlovesCosts;
        
        #line default
        #line hidden
        
        
        #line 1110 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglIsopropanol;
        
        #line default
        #line hidden
        
        
        #line 1114 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbResinApplyWashingCosts;
        
        #line default
        #line hidden
        
        
        #line 1206 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglFilters;
        
        #line default
        #line hidden
        
        
        #line 1211 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbResinApplyFilterCosts;
        
        #line default
        #line hidden
        
        
        #line 1310 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglRefreshRate;
        
        #line default
        #line hidden
        
        
        #line 1315 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbPowderApplyRefreshRate;
        
        #line default
        #line hidden
        
        
        #line 1396 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSearchPrinter;
        
        #line default
        #line hidden
        
        
        #line 1397 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PrintCostCalculator3d.Controls.MultiSelectListBox lbPrinters;
        
        #line default
        #line hidden
        
        
        #line 1485 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSearchMaterial;
        
        #line default
        #line hidden
        
        
        #line 1486 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PrintCostCalculator3d.Controls.MultiSelectListBox lbMaterials;
        
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
            System.Uri resourceLocater = new System.Uri("/3dPrintCostCalculator2;component/views/dashboard/dashboardcalculatorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Dashboard\DashboardCalculatorView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.cbCalculation = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tglGeneralEnergyCosts = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 4:
            this.cbkApplyEnergyCosts = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.tglGeneralTaxRate = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 6:
            this.ckbApplyTaxes = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.nudTaxRate = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 8:
            this.tglAdvancedMarginSettings = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 9:
            this.ckbApplyAdvancedMarginSettings = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.ckbProcedureSpecificAdditions = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.tglNozzleWear = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 12:
            this.ckbFilamentApplyNozzleWearCosts = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            this.tglPrintSheetWear = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 14:
            this.ckbFilamentApplyPrintSheetWearCosts = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 15:
            this.tglGloves = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 16:
            this.ckbResinApplyGlovesCosts = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 17:
            this.tglIsopropanol = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 18:
            this.ckbResinApplyWashingCosts = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 19:
            this.tglFilters = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 20:
            this.ckbResinApplyFilterCosts = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 21:
            this.tglRefreshRate = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 22:
            this.ckbPowderApplyRefreshRate = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 23:
            this.TextBoxSearchPrinter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 24:
            this.lbPrinters = ((PrintCostCalculator3d.Controls.MultiSelectListBox)(target));
            return;
            case 25:
            this.TextBoxSearchMaterial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 26:
            this.lbMaterials = ((PrintCostCalculator3d.Controls.MultiSelectListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

