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
        #endregion

        #region Properties
        public ViewModelBase SelectedViewModel { get => _SelectedViewModel; set => SetProperty(nameof(SelectedViewModel), ref _SelectedViewModel, value); }
        #endregion

        #region Constructors
        public ViewModelMain2()
        {
            SelectedViewModel = new ViewModelHome();
        }
        #endregion

        #region Methods

        #endregion
    }
}
