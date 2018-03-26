using CoursWPF1.ViewModels;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace CoursWPF1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : MetroWindow
    {
        public MainWindow2()
        {
            DataContext = new ViewModelMain2();
            InitializeComponent();
        }
    }
}
