using MVVMLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMLib.ViewModels;

namespace CoursWPF1.ViewModels
{
    public class ViewModelMain : ViewModelList<ViewModelBase>
    {
        #region Constructors
        public ViewModelMain() { }
        #endregion

        #region Methods
        protected override void AddItem_Execute (object parameter)
        {
            if (parameter is Type viewModelType && viewModelType.GetConstructor(Type.EmptyTypes).Invoke(null) is ViewModelBase viewModel)
            {
                ItemsSource.Add(viewModel);
                SelectedItem = viewModel;
            }
        }
        #endregion
    }
}
