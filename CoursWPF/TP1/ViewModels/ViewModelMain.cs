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
    public class ViewModelMain : ViewModelBase
    {
        #region Fields
        private ViewModelPeople _VMPeople;
        private ViewModelPersonType _VMPersonType;
        private ViewModelBase _SelectedViewModel;
        #endregion

        #region Properties
        public ViewModelPeople VMPeople { get => _VMPeople; private set => SetProperty(nameof(VMPeople), ref _VMPeople, value); }
        public ViewModelPersonType VMPersonType { get => _VMPersonType; private set => SetProperty(nameof(VMPersonType), ref _VMPersonType, value); }
        public ViewModelBase SelectedViewModel { get => _SelectedViewModel; set => SetProperty(nameof(SelectedViewModel), ref _SelectedViewModel, value); }
        #endregion

        #region Constructors
        public ViewModelMain()
        {
            VMPeople = new ViewModelPeople();
            VMPersonType = new ViewModelPersonType();
            SelectedViewModel = VMPeople;
        }
        #endregion
    }
}
