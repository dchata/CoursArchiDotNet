using CoursWPF1.Models;
using MVVMLib.Core;
using MVVMLib.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF1.ViewModels
{
    public class ViewModelPersonType : ViewModelList<PersonType>
    {
        #region Constructors
        public ViewModelPersonType()
        {
            ItemsSource.Add(new PersonType { Name = "Coworkers" });
            ItemsSource.Add(new PersonType { Name = "Family" });
        }
        #endregion

        #region Methods
        protected override void AddItem_Execute(object parameter)
        {
            base.AddItem_Execute(parameter);

            SelectedItem.Name = "New";
        }
        #endregion
    }
}
