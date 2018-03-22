using CoursWPF1.Core;
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
    public class ViewModelPeople
    {
        #region Fields
        private ObservableCollection<Person> _Persons;
        private DelegateCommand _AddItemCommand;
        private Person _SelectedItem;
        private DelegateCommand _RemoveItemCommand;
        #endregion

        #region Properties
        public ObservableCollection<Person> Persons { get => _Persons; set => _Persons = value; }
        public DelegateCommand AddItemCommand { get => _AddItemCommand; set => _AddItemCommand = value; }
        public Person SelectedItem { get => _SelectedItem; set => _SelectedItem = value; }
        public DelegateCommand RemoveItemCommand { get => _RemoveItemCommand; set => _RemoveItemCommand = value; }

        #endregion

        #region Constructors
        public ViewModelPeople()
        {

            #region Commands
            AddItemCommand = new DelegateCommand(AddItem_Execute);
            RemoveItemCommand = new DelegateCommand(RemoveItem_Execute);
            #endregion

            #region ListPersons
            Persons = new ObservableCollection<Person>
            {
                new Person
                {
                    Firstname = "Dylan",
                    Lastname = "CHATAGNIER"
                },
                new Person
                {
                    Firstname = "JM",
                    Lastname = "Gégé"
                },
                new Person
                {
                    Firstname = "Truc",
                    Lastname = "Bidule"
                }
            };
            #endregion
        }
        #endregion

        #region Methods
        private void AddItem_Execute(object parameter)
        {
            var p = new Person
            {
                Firstname = "Dorian",
                Lastname = "Maignan"
            };

            Persons.Add(p);

            SelectedItem = p;
        }
        private void RemoveItem_Execute(object parameter)
        {
            if(SelectedItem != null)
                Persons.Remove(SelectedItem);
        }

        private bool RemoveItem_CanExecute(object parameter) => SelectedItem != null;
        #endregion
    }
}
