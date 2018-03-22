using CoursWPF1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF1.Models
{
    public class PersonType : ObservableObject
    {
        #region Fields
        private string _Name;
        #endregion

        #region Properties
        public string Name { get => _Name; set => SetProperty(nameof(Name), ref _Name, value); }
        #endregion
    }
}
