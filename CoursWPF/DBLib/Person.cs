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
    
    public partial class Person : ObservableObject
    {
        private int _Identifier; public int Identifier { get { return _Identifier; } set { SetProperty(nameof(Identifier), ref _Identifier, value); } }
        private int _IdentifierPersonType; public int IdentifierPersonType { get { return _IdentifierPersonType; } set { SetProperty(nameof(IdentifierPersonType), ref _IdentifierPersonType, value); } }
        private string _FirstName; public string FirstName { get { return _FirstName; } set { SetProperty(nameof(FirstName), ref _FirstName, value); } }
        private string _LastName; public string LastName { get { return _LastName; } set { SetProperty(nameof(LastName), ref _LastName, value); } }
        private Nullable<System.DateTime> _Birthdate; public Nullable<System.DateTime> Birthdate { get { return _Birthdate; } set { SetProperty(nameof(Birthdate), ref _Birthdate, value); } }
        private string _EMail; public string EMail { get { return _EMail; } set { SetProperty(nameof(EMail), ref _EMail, value); } }
    
        private PersonType _PersonType; public virtual PersonType PersonType { get { return _PersonType; } set { SetProperty(nameof(PersonType), ref _PersonType, value); } }
    }
}