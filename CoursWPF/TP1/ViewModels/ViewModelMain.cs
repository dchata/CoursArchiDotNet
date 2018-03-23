using MVVMLib.Core;
using CoursWPF1.Models;
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
        #region Fields
        private DelegateCommand _OpenTabItemCommand;
        #endregion

        #region Properties
        public DelegateCommand OpenTabItemCommand => _OpenTabItemCommand;
        #endregion

        #region Constructors
        public ViewModelMain()
        {
            _OpenTabItemCommand = new DelegateCommand(OpenTabItemCommand_Execute);
        }
        #endregion

        #region Methods
        protected virtual void OpenTabItemCommand_Execute(object parameter)
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
