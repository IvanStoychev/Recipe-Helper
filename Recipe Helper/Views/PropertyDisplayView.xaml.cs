﻿using Recipe_Helper.ViewModels;
using System;
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

namespace Recipe_Helper.Views
{
    /// <summary>
    /// Interaction logic for PropertyDisplayView.xaml
    /// </summary>
    public partial class PropertyDisplayView : UserControl
    {
        public PropertyDisplayView()
        {
            InitializeComponent();
            cbPropertyType.ItemsSource = PropertyDisplayViewModel.GetPropertyTypes();
        }
    }
}
