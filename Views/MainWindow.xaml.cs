﻿using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VM();
        }

        private void MyAgony_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VM.RowIndexSelected = MyAgony.SelectedIndex;
        }
    }
}
