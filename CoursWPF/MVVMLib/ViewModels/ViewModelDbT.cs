﻿using MVVMLib.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMLib.ViewModels
{
    public class ViewModelDbT<T> where T : DbContext, new()
    {
        #region Fields
        private T _Entities;
        DelegateCommand _SaveCommand;
        DelegateCommand _RefreshCommand;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient l'instance du <see cref="T"/>
        /// </summary>
        public T Entities => _Entities;
        /// <summary>
        /// Obtient la commande pour sauvegarder le contexte.
        /// </summary>
        public DelegateCommand SaveCommand => _SaveCommand;
        /// <summary>
        /// Obtient la commande pour rafraîchir le contexte.
        /// </summary>
        public DelegateCommand RefreshCommand => _RefreshCommand;
        #endregion

        #region Constructors
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="ViewModelDbT{T}"/>
        /// </summary>
        public ViewModelDbT()
        {
            InitEntities();
            InitCommands();
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="ViewModelDbT{T}"/> avec un contexte <see cref="T"/> spécifique
        /// </summary>
        /// <param name="entities"> Instance du contexte <see cref="T"/> </param>
        public ViewModelDbT(T entities)
        {
            _Entities = entities;
            InitCommands();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Méthode d'initialisation de l'instance du <see cref="T"/>
        /// </summary>
        protected virtual void InitEntities() => _Entities = new T();

        private void InitCommands()
        {
            _SaveCommand = new DelegateCommand(Save_Execute, Save_CanExecute);
            _RefreshCommand = new DelegateCommand(Refresh_Execute, Refresh_CanExecute);
        }

        #region Commands
        /// <summary>
        /// Méthode d'exécution de la commande <see cref="Save_Execute(object)"/>
        /// </summary>
        /// <param name="parameter"></param>
        protected virtual void Save_Execute(object parameter)
        {
            try
            {
                Entities.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur");
            }
        }

        /// <summary>
        /// Méthode d'exécution de la commande <see cref="Save_CanExecute(object)"/>
        /// </summary>
        /// <param name="parameter"></param>
        protected virtual bool Save_CanExecute(object parameter) => Entities?.ChangeTracker?.HasChanges() ?? false;

        /// <summary>
        /// Méthode d'exécution de la commande <see cref="Refresh_Execute(object)"/>
        /// </summary>
        /// <param name="parameter"></param>
        protected virtual void Refresh_Execute(object parameter) { }

        /// <summary>
        /// Méthode d'exécution de la commande <see cref="Refresh_CanExecute(object)"/>
        /// </summary>
        /// <param name="parameter"></param>
        protected virtual bool Refresh_CanExecute(object parameter) => true;
        #endregion
        #endregion
    }
}
