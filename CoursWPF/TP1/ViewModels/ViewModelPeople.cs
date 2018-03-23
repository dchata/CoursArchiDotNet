using MVVMLib.Core;
using MVVMLib.ViewModels;
using CoursWPF1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CoursWPF1.ViewModels
{
    public class ViewModelPeople : ViewModelList<Person>
    {
        #region Constructors
        public ViewModelPeople()
        {
            ItemsSource.Add(new Person { Firstname = "Dylan",   Lastname = "CHATAGNIER" });
            ItemsSource.Add(new Person { Firstname = "JM",      Lastname = "Gégé" });
            ItemsSource.Add(new Person { Firstname = "Truc",    Lastname = "Bidule" });
        }
        #endregion

        #region Methods
        protected override void AddItem_Execute(object parameter)
        {
            base.AddItem_Execute(parameter);

            SelectedItem.Firstname = "Test";
            SelectedItem.Lastname = "DC";
        }
        #endregion
    }
}
