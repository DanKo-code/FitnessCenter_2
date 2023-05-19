using FitnessCenter.BD.EntitiesBD;
using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using FitnessCenter.Views.Windows.Main.UserControls.AdminPanel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FitnessCenter.ViewModel
{
    public class AbonementsViewModel : ObservableObject
    {
        private UnitOfWork context;

        public ObservableCollection<Services> ServicesList { get; set; }

        #region Accessors (helpers for ui design)

        #region SearchString
        private string _searchString;

        public string SearchString
        {
            get => _searchString;

            set
            {
                if (_searchString != value)
                {
                    _searchString = value;
                    OnPropertyChanged(nameof(SearchString));
                }
            }
        }
        #endregion

        #region AbonementItems
        private List<Abonements> _abonementItems = new List<Abonements>();

        public List<Abonements> AbonementItems
        {
            get => _abonementItems;

            set
            {
                if (value != _abonementItems)
                {


                    _abonementItems = value;
                    OnPropertyChanged(nameof(AbonementItems));
                }
            }
        }
        #endregion

        private ObservableCollection<Abonements> _searchedList;

        public ObservableCollection<Abonements> SearchedList
        {
            get => _searchedList;

            set
            {
                if (value != _searchedList)
                {


                    _searchedList = value;
                    OnPropertyChanged(nameof(SearchedList));
                }
            }
        }


        #region CurrentClient
        private Clients _client;

        public Clients CurrentClient
        {
            get => _client;

            set
            {
                if (_client != value)
                {
                    _client = value;
                    OnPropertyChanged(nameof(CurrentClient));
                }
            }
        }
        #endregion

        #region SelectedProducts
        private Abonements _selectedAbonement;

        public Abonements SelectedProducts
        {
            get => _selectedAbonement;

            set
            {
                if (value != null && _selectedAbonement != value)
                {
                    _selectedAbonement = value;
                    OnPropertyChanged(nameof(SelectedProducts));
                }
            }
        }
        #endregion

        #region SelectedService
        private Services _selectedService;

        public Services SelectedService
        {
            get => _selectedService;

            set
            {
                if (_selectedService != value)
                {
                    
                    _selectedService = value;
                    OnPropertyChanged(nameof(SelectedService));
                }
            }
        }
        #endregion

        #endregion

        #region Commands

        #region SearchAbonementByName
        public ICommand SearchAbonements { get; }

        private bool CanSearchAbonementsCommand(object p)
        {
            //return !canAdd;

            return true;
        }

        private void OnSearchAbonementsCommand(object p)
        {
            if(SelectedService == null)
                SearchedList = new ObservableCollection<Abonements>(AbonementItems);
            else 
            {
                if (SelectedService.Title == "Все категории")
                {
                    SearchedList = new ObservableCollection<Abonements>(AbonementItems);
                }
                else
                    SearchedList = new ObservableCollection<Abonements>(AbonementItems.Where(x => x.Services.Contains(SelectedService)).ToList());

            }




            if (SearchString == "" || SearchString == null)
                return;

            SearchedList = new ObservableCollection<Abonements>(SearchedList.Where(x=>x.Title.Contains(SearchString)));

            


        }
        #endregion

        #region AddOrder
        public ICommand AddOrder { get; }

        private bool CanAddOrderCommand(object p)
        {
            return SelectedProducts != null;
        }

        private void OnAddOrderCommand(object p)
        {
            context.OrderRepo.AddOrder(CurrentClient, SelectedProducts);
            MessageBox.Show("Заказ успешно отправлен на подтверждение!");
        }
        #endregion

        #region ReloudAbonementsList
        public ICommand ReloudAbonementsList { get; }

        private bool CanReloudAbonementsListCommand(object p)
        {
            return true;
        }

        private void OnReloudAbonementsListCommand(object p)
        {
            //AbonementItems = Helpers.CurrentClient.abonements;
            AbonementItems = context.AbonementRepo.GetAllAbonements().ToList();
            SearchedList = new ObservableCollection<Abonements>( context.AbonementRepo.GetAllAbonements().ToList());
        }
        #endregion

        #endregion

        public AbonementsViewModel()
        {

            context = new UnitOfWork();

            ServicesList = new ObservableCollection<Services>(context.ServiceRepo.GetAllServices());
            ServicesList.Add(new Services() { Title="Все категории"});


            CurrentClient = Helpers.CurrentClient.client;

            SearchAbonements = new RelayCommand(OnSearchAbonementsCommand, CanSearchAbonementsCommand);

            AddOrder = new RelayCommand(OnAddOrderCommand, CanAddOrderCommand);

            ReloudAbonementsList = new RelayCommand(OnReloudAbonementsListCommand, CanReloudAbonementsListCommand);

            AbonementItems = Helpers.CurrentClient.abonements;
            AbonementItems = context.AbonementRepo.GetAllAbonements();

            SearchedList = new ObservableCollection<Abonements>(context.AbonementRepo.GetAllAbonements());
        }

    }
}
