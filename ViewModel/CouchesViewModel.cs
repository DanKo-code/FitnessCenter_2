using FitnessCenter.BD.EntitiesBD;
using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #endregion

        public CouchesViewModel()
        {
            context = new UnitOfWork();

            CouchesList = new ObservableCollection<Couches>(context.CoucheRepo.GetAllCouches());
        }
    }
}
