#pragma checksum "..\..\LoanTransaction.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A8949C63839A481EE7501CFE3E578C1A4F491133"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OOP_Final_Project;
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


namespace OOP_Final_Project
{


    /// <summary>
    /// LoanTransaction
    /// </summary>
    public partial class LoanTransaction : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 14 "..\..\LoanTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbNameList;

#line default
#line hidden


#line 15 "..\..\LoanTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddName;

#line default
#line hidden


#line 23 "..\..\LoanTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbJewelryQuality;

#line default
#line hidden


#line 29 "..\..\LoanTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbWeight;

#line default
#line hidden


#line 32 "..\..\LoanTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbDiscount;

#line default
#line hidden


#line 35 "..\..\LoanTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock actualValueText;

#line default
#line hidden


#line 41 "..\..\LoanTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbAmountLoaned;

#line default
#line hidden


#line 42 "..\..\LoanTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCurrentDate;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OOP Final Project;component/loantransaction.xaml", System.UriKind.Relative);

#line 1 "..\..\LoanTransaction.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 10 "..\..\LoanTransaction.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.cmbNameList = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 3:
                    this.btnAddName = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\LoanTransaction.xaml"
                    this.btnAddName.Click += new System.Windows.RoutedEventHandler(this.btnAddName_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.cmbJewelryQuality = ((System.Windows.Controls.ComboBox)(target));

#line 23 "..\..\LoanTransaction.xaml"
                    this.cmbJewelryQuality.DropDownClosed += new System.EventHandler(this.cmbJewelryQuality_DropDownClosed);

#line default
#line hidden
                    return;
                case 5:
                    this.txtbWeight = ((System.Windows.Controls.TextBox)(target));

#line 29 "..\..\LoanTransaction.xaml"
                    this.txtbWeight.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.WeightTextBox_TextChanged);

#line default
#line hidden
                    return;
                case 6:
                    this.txtbDiscount = ((System.Windows.Controls.TextBox)(target));

#line 32 "..\..\LoanTransaction.xaml"
                    this.txtbDiscount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtDiscount_TextChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.actualValueText = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 8:
                    this.txtbAmountLoaned = ((System.Windows.Controls.TextBox)(target));

#line 41 "..\..\LoanTransaction.xaml"
                    this.txtbAmountLoaned.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtDiscount_TextChanged);

#line default
#line hidden
                    return;
                case 9:
                    this.btnCurrentDate = ((System.Windows.Controls.Button)(target));

#line 42 "..\..\LoanTransaction.xaml"
                    this.btnCurrentDate.Click += new System.Windows.RoutedEventHandler(this.btnUseCurrentDate);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.ComboBox cmbTypeOfJewelry;
    }
}

