﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrintCostCalculator3d.Views
{
    /// <summary>
    /// Interaktionslogik für CredentialDialog.xaml
    /// </summary>
    public partial class CredentialDialog : UserControl
    {
        public CredentialDialog()
        {
            InitializeComponent();
        }

        void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // Need to be in loaded event, focusmanger won't work...
            TextBoxName.Focus();
        }
    }
}
