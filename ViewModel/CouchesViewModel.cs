using FitnessCenter.BD.EntitiesBD;
using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using FitnessCenter.Helpers;
using FitnessCenter.Views.Windows.LoginRegistration;
using FitnessCenter.Views.Windows.Main;

namespace FitnessCenter.ViewModel
{
    public class CouchesViewModel : ObservableObject
    {
        private UnitOfWork context;

        public ObservableCollection<Couches> CouchesList { get; set; }

        #region Accessors (helpers for ui design)

        #region SelectedCouches
        private Couches _selectedCouches;

        public Couches SelectedCouches
        {
            get => _selectedCouches;

            set
            {
                if (value != null && _selectedCouches != value)
                {
                    _selectedCouches = value;
                    OnPropertyChanged(nameof(SelectedCouches));
                }
            }
        }
        #endregion

        #endregion

        #region Commands

        //#region ShowMoreInfWind
        //public ICommand ShowMoreInfWind { get; }

        //private bool CanShowMoreInfWindCommand(object p) => true;

        //private void OnShowMoreInfWindCommand(object couches)
        //{


        //    FitnessCenter.Views.Windows.Main.UserControls.Couches.SelectedCouch selectedCouch = new FitnessCenter.Views.Windows.Main.UserControls.Couches.SelectedCouch(SelectedCouches);
        //    selectedCouch.Show();
        //}
        //#endregion

        #endregion

        public CouchesViewModel()
        {
            //ShowMoreInfWind = new RelayCommand(OnShowMoreInfWindCommand, CanShowMoreInfWindCommand);

            context = new UnitOfWork();

            CouchesList = new ObservableCollection<Couches>(context.CoucheRepo.GetAllCouches());
        }
    }
}
