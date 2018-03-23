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
        private ViewModelPeople _VMPeople;
        private ViewModelPersonType _VMPersonType;
        #endregion

        #region Constructors
        public ViewModelMain()
        {
            _VMPeople = new ViewModelPeople();
            _VMPersonType = new ViewModelPersonType();

            ItemsSource.Add(_VMPeople);
            ItemsSource.Add(_VMPersonType);

            SelectedItem = _VMPeople;
        }
        #endregion
    }
}
