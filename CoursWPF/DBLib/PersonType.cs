//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBLib
{
    using System;
    using System.Collections.ObjectModel;
    using MVVMLib.Core;
    
    public partial class PersonType : ObservableObject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonType()
        {
            this.People = new ObservableCollection<Person>();
        }
    
        private int _Identifier; public int Identifier { get { return _Identifier; } set { SetProperty(nameof(Identifier), ref _Identifier, value); } }
        private string _Name; public string Name { get { return _Name; } set { SetProperty(nameof(Name), ref _Name, value); } }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ObservableCollection<Person> _People; public virtual ObservableCollection<Person> People { get { return _People; } set { SetProperty(nameof(People), ref _People, value); } }
    }
}
