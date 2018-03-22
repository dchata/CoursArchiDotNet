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
        private Person _Person;
        private DelegateCommand _ResetCommand;
        #endregion

        #region Properties
        public Person Person { get => _Person; set => SetProperty(nameof(Person), ref _Person, value); }
        public DelegateCommand ResetCommand => _ResetCommand;
        #endregion

        #region Constructors
        public ViewModelMain()
        {
            _ResetCommand = new DelegateCommand(Reset, CanReset);
            ResetCommand.Execute(null);
        }
        #endregion

        #region Methods
        private void Reset(object parameter) => Person = new Person();

        private bool CanReset(object parameter) => !string.IsNullOrWhiteSpace(Person?.Fullname);
        #endregion
    }
}
