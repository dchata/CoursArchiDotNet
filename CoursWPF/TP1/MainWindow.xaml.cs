﻿using CoursWPF1.Models;
using CoursWPF1.ViewModels;
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

namespace CoursWPF1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new ViewModels.ViewModelMain();
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tItemPeople.IsSelected)
                ((ViewModelMain)DataContext).SelectedViewModel = ((ViewModelMain)DataContext).VMPeople;
            else if (tItemPersonType.IsSelected)
                ((ViewModelMain)DataContext).SelectedViewModel = ((ViewModelMain)DataContext).VMPersonType;
        }
    }
}
