using DBLib;
using MVVMLib.Core;
using MVVMLib.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CoursWPF1.ViewModels
{
    public class ViewModelPeople : ViewModelDbList<AddressBookEntities, Person>
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
            VMPersonType = new ViewModelPersonType(Entities);
            Header = "Personnes";
        }
        #endregion

        #region Methods
        protected override void AddItem_Execute(object parameter)
        {
            base.AddItem_Execute(parameter);
            
            SelectedItem.FirstName = "Test";
            SelectedItem.LastName = "DC";
        }

        protected override void Refresh_Execute(object parameter)
        {
            base.Refresh_Execute(parameter);

            DbSet.Include(nameof(Person.PersonType)).ToList();
        }
        #endregion
    }
}
