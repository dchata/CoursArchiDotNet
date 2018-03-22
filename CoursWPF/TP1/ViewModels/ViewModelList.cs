using CoursWPF1.Core;
using CoursWPF1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF1.ViewModels
{
    /// <summary>
    /// Le type T doit être un ObservableObject et avoir un constructeur vide
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ViewModelList<T> : ObservableObject where T : ObservableObject, new()
    {
        #region Fields
        private ObservableCollection<T> _ItemsSource;
        private DelegateCommand _AddItemCommand;
        private T _SelectedItem;
        private DelegateCommand _RemoveItemCommand;
        #endregion

        #region Properties
        public DelegateCommand AddItemCommand { get => _AddItemCommand; set => _AddItemCommand = value; }
        public DelegateCommand RemoveItemCommand { get => _RemoveItemCommand; set => _RemoveItemCommand = value; }
        public ObservableCollection<T> ItemsSource { get => _ItemsSource; private set => SetProperty(nameof(ItemsSource), ref _ItemsSource, value); }
        public T SelectedItem { get => _SelectedItem; set => SetProperty(nameof(SelectedItem), ref _SelectedItem, value); }

        #endregion

        #region Constructors
        public ViewModelList()
        {
            #region Commands
            AddItemCommand = new DelegateCommand(AddItem_Execute);
            RemoveItemCommand = new DelegateCommand(RemoveItem_Execute, RemoveItem_CanExecute);
            #endregion

            ItemsSource = new ObservableCollection<T>();
        }

        #endregion

        #region AddItemCommand
        protected virtual void AddItem_Execute(object parameter)
        {
            T item = new T();

            ItemsSource.Add(item);
            SelectedItem = item;
        }
        protected virtual void RemoveItem_Execute(object parameter)
        {
            if(parameter is T itemToDelete)
                ItemsSource.Remove(itemToDelete);
            else if(SelectedItem != null)
                ItemsSource.Remove(SelectedItem);
        }

        protected virtual bool RemoveItem_CanExecute(object parameter) => SelectedItem != null || parameter is T;

        #endregion
    }
}
