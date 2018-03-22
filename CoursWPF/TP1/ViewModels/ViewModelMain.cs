using CoursWPF1.Core;
using CoursWPF1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF1.ViewModels
{
    public class ViewModelMain : ObservableObject
    {
        #region Fields
        private ViewModelPeople _VMPeople;
        private ViewModelPersonType _VMPersonType;
        private ObservableObject _SelectedViewModel;
        #endregion

        #region Properties
        public ViewModelPeople VMPeople { get => _VMPeople; private set => SetProperty(nameof(VMPeople), ref _VMPeople, value); }
        public ViewModelPersonType VMPersonType { get => _VMPersonType; private set => SetProperty(nameof(VMPersonType), ref _VMPersonType, value); }
        public ObservableObject SelectedViewModel { get => _SelectedViewModel; set => SetProperty(nameof(SelectedViewModel), ref _SelectedViewModel, value); }
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
