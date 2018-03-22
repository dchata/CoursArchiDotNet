﻿using CoursWPF1.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF1.Models
{
    public class Person : ObservableObject
    {
        #region Fields
        private string _Lastname;
        private string _Firstname;
        #endregion

        #region Properties
        public string Firstname { get => _Firstname; set => SetProperty(nameof(Firstname), ref _Firstname, value); }
        public string Lastname { get => _Lastname; set => SetProperty(nameof(Lastname), ref _Lastname, value); }
        public string Fullname => Firstname + " " + Lastname;
        #endregion

        #region Methods
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            switch (propertyName)
            {
                case nameof(Firstname):
                case nameof(Lastname):
                    OnPropertyChanged(nameof(Fullname));
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
