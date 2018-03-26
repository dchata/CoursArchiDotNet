﻿using MVVMLib.Core;
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
        #region Fields
        private ViewModelPersonType _VMPersonType;
        #endregion
        
        #region Properties
        public ViewModelPersonType VMPersonType { get => _VMPersonType; private set => SetProperty(nameof(VMPersonType), ref _VMPersonType, value); }
        #endregion

        #region Constructors
        public ViewModelPeople()
        {
            VMPersonType = new ViewModelPersonType();
            Header = "Personnes";
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
