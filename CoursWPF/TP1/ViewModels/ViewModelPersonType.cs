using DBLib;
using MVVMLib.Core;
using MVVMLib.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF1.ViewModels
{
    public class ViewModelPersonType : ViewModelDbList<AddressBookEntities, PersonType>
    {
        #region Constructors
        public ViewModelPersonType()
        {
            Header = "Types de personnes";
        }

        public ViewModelPersonType(AddressBookEntities entities)
            : base(entities)
        {
            this.Header = "Types de personnes";
        }
        #endregion

        #region Methods
        protected override void AddItem_Execute(object parameter)
        {
            base.AddItem_Execute(parameter);
            
            SelectedItem.Name = "Nouveau type";
        }

        protected override void Refresh_Execute(object parameter)
        {
            base.Refresh_Execute(parameter);

            DbSet.ToList();
        }
        #endregion
    }
}
