using CoursWPF1.Models;
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
        //ViewModels.ViewModelMain _VM;
        ViewModels.ViewModelPeople _VM;
        public MainWindow()
        {
            //_VM = new ViewModels.ViewModelMain();
            _VM = new ViewModels.ViewModelPeople();
            DataContext = _VM;
            InitializeComponent();
        }
    }
}
