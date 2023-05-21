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
using FitnessCenter.BD;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenter.ViewModel
{
    public class CouchesViewModel : ObservableObject
    {
        private UnitOfWork context;

        private ObservableCollection<Couches> _couchesList;
        public ObservableCollection<Couches> CouchesList
        {
            get => _couchesList;
            set
            {
                _couchesList = value;
                OnPropertyChanged("CouchesList");
            }
        }

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

        #region ReloudAbonementsList
        public ICommand ReloudAbonementsList { get; }

        private bool CanReloudAbonementsListCommand(object p)
        {
            return true;
        }

        private void OnReloudAbonementsListCommand(object p)
        {
            using (BDContext bd = new BDContext())
            {
                CouchesList = new ObservableCollection<Couches>(bd.Couches.Include(x=>x.Services).ToList());
            }

                //CouchesList = new ObservableCollection<Couches>(context.CoucheRepo.GetAllCouches());
        }
        #endregion

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
            ReloudAbonementsList = new RelayCommand(OnReloudAbonementsListCommand, CanReloudAbonementsListCommand);

            context = new UnitOfWork();

            CouchesList = new ObservableCollection<Couches>(context.CoucheRepo.GetAllCouches());
        }
    }
}
