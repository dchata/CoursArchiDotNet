using MVVMLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMLib.ViewModels;

namespace CoursWPF1.ViewModels
{
    public class ViewModelMain2 : ViewModelBase
    {
        #region Fields
        private ViewModelBase _SelectedViewModel;
        private DelegateCommand _NavigateCommand;
        #endregion

        #region Properties
        public ViewModelBase SelectedViewModel { get => _SelectedViewModel; set => SetProperty(nameof(SelectedViewModel), ref _SelectedViewModel, value); }
        public DelegateCommand NavigateCommand => _NavigateCommand;
        #endregion

        #region Constructors
        public ViewModelMain2()
        {
            SelectedViewModel = new ViewModelHome();
            _NavigateCommand = new DelegateCommand(Navigate_Execute, Navigate_CanExecute);
        }
        #endregion

        #region Methods
        private void Navigate_Execute(object parameter)
        {
            if (parameter is ViewModelBase vm)
                SelectedViewModel = vm;
            else if (parameter is Type vmType && typeof(ViewModelBase).IsAssignableFrom(vmType) && vmType.GetConstructor(Type.EmptyTypes).Invoke(null) is ViewModelBase viewModel)
                SelectedViewModel = viewModel;
        }

        private bool Navigate_CanExecute(object parameter) => parameter is ViewModelBase || (parameter is Type vmType && typeof(ViewModelBase).IsAssignableFrom(vmType));
        #endregion
    }
}
