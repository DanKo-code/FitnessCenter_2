using FitnessCenter.BD.EntitiesBD;
using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using FitnessCenter.Views.Windows.Main.UserControls.AdminPanel;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FitnessCenter.ViewModel
{
    public class AdminPanelViewModel : ObservableObject
    {
        //EF
        private UnitOfWork context;

        //Ебанутая система
        bool canAdd = true;

        //Список абонементов
        public ObservableCollection<Abonements> AbonementsList { get; set; }
        public ObservableCollection<Abonements> SearchedList { get; set; }
        public ObservableCollection<Couches> SearchedCouchesList { get; set; }

        //Список заказов
        private ObservableCollection<Orders> _ordersList;

        public ObservableCollection<Couches> CouchesList { get; set; }

        public ObservableCollection<Orders> OrdersList
        {
            get => _ordersList;

            set
            {
                if (_ordersList != value)
                {
                    _ordersList = value;
                    OnPropertyChanged(nameof(OrdersList));
                }
            }
        }

        #region Accessors (helpers for ui design)

        #region ButtonStyle
        private Style _buttonStyle;

        public Style ButtonStyle
        {
            get => _buttonStyle;

            set
            {
                _buttonStyle = value;
                OnPropertyChanged(nameof(ButtonStyle));
            }
        }
        #endregion

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

                    if (MyEvent != null)
                    {
                        MyEvent(this, EventArgs.Empty);
                    }
                }
            }
        }
        #endregion

        #region CouchesListVisibility
        private Visibility _couchesListVisibility = Visibility.Collapsed;

        public Visibility CouchesListVisibility
        {
            get => _couchesListVisibility;

            set
            {
                if (_couchesListVisibility != value)
                {
                    _couchesListVisibility = value;
                    OnPropertyChanged(nameof(CouchesListVisibility));
                }
            }
        }
        #endregion

        #region CouchesPanelVisibility
        private Visibility _couchesPanelVisibility = Visibility.Collapsed;

        public Visibility CouchesPanelVisibility
        {
            get => _couchesPanelVisibility;

            set
            {
                if (_couchesPanelVisibility != value)
                {
                    _couchesPanelVisibility = value;
                    OnPropertyChanged(nameof(CouchesPanelVisibility));
                }
            }
        }
        #endregion

        #region RSelectedItem
        private Services _rSelectedItem;

        public Services RSelectedItem
        {
            get => _rSelectedItem;

            set
            {
                if (_rSelectedItem != value)
                {
                    _rSelectedItem = value;
                    OnPropertyChanged(nameof(RSelectedItem));
                }
            }
        }
        #endregion

        #region NewServiceName
        private string _newServiceName;

        public string NewServiceName
        {
            get => _newServiceName;

            set
            {
                if (_newServiceName != value)
                {
                    _newServiceName = value;
                    OnPropertyChanged(nameof(NewServiceName));
                }
            }
        }
        #endregion

        #region ServicesList


        public ObservableCollection<Services> _servicesList;
        public ObservableCollection<Services> ServicesList
        {
            get => _servicesList;

            set
            {
                if (_servicesList != value)
                {
                    _servicesList = value;

                    OnPropertyChanged(nameof(ServicesList));
                }
            }
        }

        #endregion

        #region AbonementTitle
        private List<Abonements> _abonementTitle;

        public List<Abonements> AbonementTitle
        {
            get => _abonementTitle;

            set
            {
                if (_abonementTitle != value)
                {
                    _abonementTitle = value;
                    OnPropertyChanged(nameof(AbonementTitle));
                }
            }
        }
        #endregion

        #region BottomAbonementsPanelVisibility
        private Visibility _bottomAbonementsPanelVisibility;

        public Visibility BottomAbonementsPanelVisibility
        {
            get => _bottomAbonementsPanelVisibility;

            set
            {
                if (_bottomAbonementsPanelVisibility != value)
                {
                    _bottomAbonementsPanelVisibility = value;
                    OnPropertyChanged(nameof(BottomAbonementsPanelVisibility));
                }
            }
        }
        #endregion

        #region SelectedProducts
        private Abonements _selectedAbonement;

        public static event EventHandler MyEvent;

        public Abonements SelectedProducts
        {
            get => _selectedAbonement;

            set
            {
                if (value != null && _selectedAbonement != value)
                {
                    _selectedAbonement = value;
                    OnPropertyChanged(nameof(SelectedProducts));

                    if (MyEvent != null)
                    {
                        MyEvent(this, EventArgs.Empty);
                    }
                }
            }
        }
        #endregion

        #region SelectedOrders
        private Orders _selectedOrders;

        public Orders SelectedOrders
        {
            get => _selectedOrders;

            set
            {
                if (value != null && _selectedOrders != value)
                {
                    _selectedOrders = value;
                    OnPropertyChanged(nameof(SelectedOrders));
                }
            }
        }
        #endregion

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

        #region AdminListView
        private string _adminListView;

        public string AdminListView
        {
            get => _adminListView;

            set
            {
                if (_adminListView != value)
                {
                    _adminListView = value;
                    OnPropertyChanged(nameof(AdminListView));
                }
            }
        }
        #endregion

        #region AbonementsPanelVisibility
        private Visibility _abonementsPanelVisibility = Visibility.Visible;

        public Visibility AbonementsPanelVisibility
        {
            get => _abonementsPanelVisibility;

            set
            {
                if (_abonementsPanelVisibility != value)
                {
                    _abonementsPanelVisibility = value;
                    OnPropertyChanged(nameof(AbonementsPanelVisibility));
                }
            }
        }
        #endregion

        #region OrdersPanelVisibility
        private Visibility _ordersPanelVisibility = Visibility.Collapsed;

        public Visibility OrdersPanelVisibility
        {
            get => _ordersPanelVisibility;

            set
            {
                if (_ordersPanelVisibility != value)
                {
                    _ordersPanelVisibility = value;
                    OnPropertyChanged(nameof(OrdersPanelVisibility));
                }
            }
        }
        #endregion

        #region AbonementsListVisibility
        private Visibility _abonementsListVisibility = Visibility.Visible;

        public Visibility AbonementsListVisibility
        {
            get => _abonementsListVisibility;

            set
            {
                if (_abonementsListVisibility != value)
                {
                    _abonementsListVisibility = value;
                    OnPropertyChanged(nameof(AbonementsListVisibility));
                }
            }
        }
        #endregion

        #region OrdersListVisibility
        private Visibility _ordersListVisibility = Visibility.Collapsed;

        public Visibility OrdersListVisibility
        {
            get => _ordersListVisibility;

            set
            {
                if (_ordersListVisibility != value)
                {
                    _ordersListVisibility = value;
                    OnPropertyChanged(nameof(OrdersListVisibility));
                }
            }
        }
        #endregion

        #region ServicesListVisibility
        private Visibility _servicesListVisibility = Visibility.Collapsed;

        public Visibility ServicesListVisibility
        {
            get => _servicesListVisibility;

            set
            {
                if (_servicesListVisibility != value)
                {
                    _servicesListVisibility = value;
                    OnPropertyChanged(nameof(ServicesListVisibility));
                }
            }
        }
        #endregion

        #region SelectedItems
        private IEnumerable<object> _selectedItems;
        public IEnumerable<object> SelectedItems
        {
            get { return _selectedItems; }
            set
            {
                _selectedItems = value;
                OnPropertyChanged("SelectedItems");
            }
        }
        #endregion

        #region SelectedServicess
        private IList<Services> _selectedServicess;
        public IList<Services> SelectedServicess
        {
            get { return _selectedServicess; }
            set
            {
                _selectedServicess = value;
                OnPropertyChanged("SelectedServicess");
            }
        }
        #endregion

        #endregion



        #region Commands



        #region ChangeServicesListVisibility 
        public ICommand ChangeServicesListVisibility { get; }

        private bool CanChangeServicesListVisibilityCommand(object p)
        {
            return true;
        }

        private void OnChangeServicesListVisibilityCommand(object p)
        {
            if (ServicesListVisibility == Visibility.Visible)
            {
                ServicesListVisibility = Visibility.Collapsed;
                return;
            }

            if (ServicesListVisibility == Visibility.Collapsed)
            {
                ServicesListVisibility = Visibility.Visible;
                return;
            }
        }
        #endregion

        #region AddService 
        public ICommand AddService { get; }

        private bool CanAddServiceCommand(object p)
        {
            return true;
        }

        private void OnAddServiceCommand(object p)
        {
            if(NewServiceName == null)
            {
                MessageBox.Show("Отсутствует название услуги!");
                return;
            }

            Services temp = new Services() { Id = new Guid(), Title = NewServiceName };

            context.ServiceRepo.AddService(temp);

            ServicesList.Add(temp);
        }
        #endregion

        #region RemoveService 
        public ICommand RemoveService { get; }

        private bool CanRemoveServiceCommand(object p)
        {
            return true;
        }

        private void OnRemoveServiceCommand(object p)
        {
            Services temp = ServicesList.FirstOrDefault(x => x.Title == NewServiceName);

            if (temp == null)
            {
                MessageBox.Show("Услуга не найдена!");
                return;
            }

            context.ServiceRepo.RemoveService(NewServiceName);

            ServicesList.Remove(temp);
        }
        #endregion

        #region ApproveOrder 
        public ICommand ApproveOrder { get; }

        private bool CanApproveOrderCommand(object p)
        {
            return SelectedOrders != null;
        }

        private void OnApproveOrderCommand(object p)
        {
            context.OrderRepo.FindById(SelectedOrders.Id).Status = 1;

            context.Save();

            OrdersList.Remove(SelectedOrders);

            //********************************Отправка на почту**************************************************************

            MessageBox.Show("Начало отправки!");
            var mail = Helpers.SMTP.CreateMail("FitnessCenter", Helpers.CurrentClient.adminEmail, Helpers.CurrentClient.client.Email, $"Заказ!", $"<b>Ваш заказ</b><br><br>{SelectedOrders.Abonement.ToString()} <br><b>Статуc:</b> одобрен! :)");

            Helpers.SMTP.SendMail("smtp.gmail.com", 587, Helpers.CurrentClient.adminEmail, Helpers.CurrentClient.adminPass, mail);

            MessageBox.Show("Отправка на почту");
        }
        #endregion

        #region RejectOrder 
        public ICommand RejectOrder { get; }

        private bool CanRejectOrderCommand(object p)
        {
            return SelectedOrders != null;
        }

        private void OnRejectOrderCommand(object p)
        {
            context.OrderRepo.FindById(SelectedOrders.Id).Status = 2;

            context.Save();

            OrdersList.Remove(SelectedOrders);

            //********************************Отправка на почту**************************************************************

            MessageBox.Show("Начало отправки!");
            var mail = Helpers.SMTP.CreateMail("FitnessCenter", Helpers.CurrentClient.adminEmail, Helpers.CurrentClient.client.Email, $"Заказ!", $"<b>Ваш заказ</b><br><br>{SelectedOrders.Abonement.ToString()} <br><b>Статуc:</b> отклонен! :)");

            Helpers.SMTP.SendMail("smtp.gmail.com", 587, Helpers.CurrentClient.adminEmail, Helpers.CurrentClient.adminPass, mail);

            MessageBox.Show("Отправка на почту");
        }
        #endregion

        //***********************************************
        #region AddAbonement
        public ICommand AddAbonement { get; }

        private bool CanAddAbonementCommand(object p)
        {
            return canAdd;
        }

        private void OnAddAbonementCommand(object p)
        {
            if(CouchesPanelVisibility == Visibility.Visible)
            {
                string photo = SelectedCouches.Photo;
                string name = SelectedCouches.Name;
                string description = SelectedCouches.Description;
                ObservableCollection<Services> services = SelectedCouches.Services;

                Couches temp = new Couches { Id = new Guid(), Name = name, Description = description, Photo = photo, Services = services };

                SelectedCouches = new Couches();

                CouchesList.Add(temp);
                SearchedCouchesList.Add(temp);
                context.CoucheRepo.AddAbonement(temp);

                //SelectedCouches = new Couches
            }
            else if(AbonementsPanelVisibility == Visibility.Visible)
            {
                //Взять поля из формы
                string? title = SelectedProducts.Title;
                int? age = SelectedProducts.Age;
                string? validity = SelectedProducts.Validity;
                string? visitingTime = SelectedProducts.VisitingTime;
                int? amount = SelectedProducts.Amount;
                int? price = SelectedProducts.Price;
                string? photo = SelectedProducts.Photo;
                ObservableCollection<Services> services = SelectedProducts.Services;

                //Abonements temp = new Abonements(title, age, validity, visitingTime, amount, price, photo);
                Abonements temp = new Abonements { Id = new Guid(), Title = title, Age = age, Validity = validity, VisitingTime = visitingTime, Amount = amount, Price = price, Photo = photo, Services = services };

                SelectedProducts = new Abonements();

                AbonementsList.Add(temp);
                SearchedList.Add(temp);
                context.AbonementRepo.AddAbonement(temp);
            }

            


        }
        #endregion

        //***********************************************
        #region Deselect 
        public ICommand Deselect { get; }

        private bool CanDeselectCommand(object p)
        {
            if (AbonementsPanelVisibility == Visibility.Visible)
            {
                foreach (Abonements item in AbonementsList)
                {
                    if (SelectedProducts.Equals(item))
                    {
                        canAdd = false;
                        break;
                    }


                }
                
            }
            
            if (CouchesPanelVisibility == Visibility.Visible)
            {
                foreach (Couches item in CouchesList)
                {
                    if (SelectedCouches.Equals(item))
                    {
                        canAdd = false;
                        break;
                    }


                }
            }


                return !canAdd;
        }

        private void OnDeselectCommand(object p)
        {
            if (AbonementsPanelVisibility == Visibility.Visible)
            {
                SelectedProducts = new Abonements();

                AbonementsList.Add(SelectedProducts);
                AbonementsList.RemoveAt(AbonementsList.Count - 1);

                SearchedList.Add(SelectedProducts);
                SearchedList.RemoveAt(SearchedList.Count - 1);
            }

            if (CouchesPanelVisibility == Visibility.Visible)
            {
                SelectedCouches = new Couches();

                CouchesList.Add(SelectedCouches);
                CouchesList.RemoveAt(CouchesList.Count - 1);

                SearchedCouchesList.Add(SelectedCouches);
                SearchedCouchesList.RemoveAt(CouchesList.Count - 1);
            }

                canAdd = true;
        }
        #endregion

        //***********************************************
        #region RemoveAbonement
        public ICommand RemoveAbonement { get; }

        private bool CanRemoveAbonementCommand(object p)
        {
            return !canAdd;
        }

        private void OnRemoveAbonementCommand(object p)
        {
            if (AbonementsPanelVisibility == Visibility.Visible)
            {
                //TODO 2
                AbonementsList.Remove(SelectedProducts);
                SearchedList.Remove(SelectedProducts);
                context.AbonementRepo.RemoveAbonement(SelectedProducts);
            }


            if (CouchesPanelVisibility == Visibility.Visible)
            {
                //TODO 2
                CouchesList.Remove(SelectedCouches);
                SearchedCouchesList.Remove(SelectedCouches);
                context.CoucheRepo.RemoveCouch(SelectedCouches);
            }
        }
        #endregion

        //***********************************************
        #region SearchAbonementByName
        public ICommand SearchAbonementByName { get; }

        private bool CanSearchAbonementByNameCommand(object p)
        {
            //return !canAdd;

            return true;
        }

        private void OnSearchAbonementByNameCommand(object p)
        {
            string pattern = SearchString;

            SearchedList.Clear();

            foreach (Abonements abonement in AbonementsList)
            {
                if (Regex.IsMatch(abonement.Title, pattern))
                {
                    SearchedList.Add(abonement);
                }
            }
        }
        #endregion

        //***********************************************
        #region SortAbonementByName
        public ICommand SortAbonementByName { get; }

        private bool CanSortAbonementByNameCommand(object p)
        {
            //return !canAdd;

            return true;
        }

        private void OnSortAbonementByNameCommand(object p)
        {
            var temp = SearchedList.OrderBy(x => x.Title).ToList();

            SearchedList.Clear();

            foreach (var item in temp)
            {
                SearchedList.Add(item);
            }
        }
        #endregion

        #region SetPhoto 
        public ICommand SetPhoto { get; }

        private bool CanSetPhotoCommand(object p)
        {
            return true;
        }
        private void OnSetPhotoCommand(object p)
        {
            ////Для стиля
            //ButtonStyle = Application.Current.Resources["myButton"] as Style;


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    if(AbonementsPanelVisibility == Visibility.Visible)
                    {
                        SelectedProducts.Photo = openFileDialog.FileName;
                    }
                    else if(CouchesPanelVisibility == Visibility.Visible)
                    {
                        SelectedCouches.Photo = openFileDialog.FileName;
                    }
                }
                catch
                {
                    MessageBox.Show("Выберите файл подходящего формата.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        #endregion



        //#region ChangeStyle 
        //public ICommand ChangeStyle { get; }

        //private bool CanChangeStyleCommand(object p)
        //{
        //    return true;
        //}
        //private void OnChangeStyleCommand(object p)
        //{
            
        //}
        //#endregion

        //***********************************************
        #region SaveAllChanges
        public ICommand SaveAllChanges { get; }

        private bool CanSaveAllChangesCommand(object p)
        {
            return true;
        }
        private void OnSaveAllChangesCommand(object p)
        {
            context.Save();

            Helpers.CurrentClient.abonements = AbonementsList.ToList();

            MessageBox.Show("Все удачно сохранено!");
        }
        #endregion


        #region ShowAbonementsPanel 
        public ICommand ShowAbonementsPanel { get; }

        private bool CanShowAbonementsPanelCommand(object p)
        {
            return true;
        }
        private void OnShowAbonementsPanelCommand(object p)
        {
            AbonementsPanelVisibility = Visibility.Visible;
            OrdersPanelVisibility = Visibility.Collapsed;
            CouchesPanelVisibility = Visibility.Collapsed;

            CouchesListVisibility = Visibility.Collapsed;
            AbonementsListVisibility = Visibility.Visible;
            OrdersListVisibility = Visibility.Collapsed;

            BottomAbonementsPanelVisibility = Visibility.Visible;
        }
        #endregion

        #region ShowOrdersPanel 
        public ICommand ShowOrdersPanel { get; }

        private bool CanShowOrdersPanelCommand(object p)
        {
            return true;
        }
        private void OnShowOrdersPanelCommand(object p)
        {
            OrdersPanelVisibility = Visibility.Visible;
            AbonementsPanelVisibility = Visibility.Collapsed;
            CouchesPanelVisibility = Visibility.Collapsed;


            CouchesListVisibility = Visibility.Collapsed;
            OrdersListVisibility = Visibility.Visible;
            AbonementsListVisibility = Visibility.Collapsed;
            BottomAbonementsPanelVisibility = Visibility.Collapsed;

            OrdersList = new ObservableCollection<Orders>(context.OrderRepo.GetAllOrder());
        }
        #endregion

        #region ShowCouchesPanel 
        public ICommand ShowCouchesPanel { get; }

        private bool CanShowCouchesPanelCommand(object p)
        {
            return true;
        }
        private void OnShowCouchesPanelCommand(object p)
        {
            OrdersPanelVisibility = Visibility.Collapsed;
            AbonementsPanelVisibility = Visibility.Collapsed;
            CouchesPanelVisibility = Visibility.Visible;

            CouchesListVisibility = Visibility.Visible;
            OrdersListVisibility = Visibility.Collapsed;
            AbonementsListVisibility = Visibility.Collapsed;
            BottomAbonementsPanelVisibility = Visibility.Visible;

            //TODO Заполнения списка всех тренеров 2
            //CouchesList = new ObservableCollection<Couches>(context.CouchesRepo.GetAllCouches());
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        #region SelectedServices 

        public ICommand SelectedServices { get; }

        private bool CanSelectedServicesCommand(object p)
        {
            return true;
        }
        private void OnSelectedServicesCommand(object p)
        {
            ObservableCollection<Services> temp = new ObservableCollection<Services>();

            if (context.AbonementRepo.GetAllAbonements().Find(x => x.Id == SelectedProducts.Id).Services != null)
            {
                context.AbonementRepo.GetAllAbonements().Find(x => x.Id == SelectedProducts.Id).Services.Clear();
                context.Save();
            }
            else
            {
                context.AbonementRepo.GetAllAbonements().Find(x => x.Id == SelectedProducts.Id).Services = new ObservableCollection<Services>();
            }




            foreach (Services item in (IList)p)
            {
                temp.Add(item);
                context.AbonementRepo.GetAllAbonements().Find(x => x.Id == SelectedProducts.Id).Services.Add(item);
                context.Save();
            }

            SelectedProducts.Services = temp;

            //context.AbonementRepo.GetAllAbonements().Find(x=>x.Id == SelectedProducts.Id).Services.Clear();
            //context.AbonementRepo.GetAllAbonements().Find(x=>x.Id == SelectedProducts.Id).Services.;
        }
        #endregion

        #region SetServicePhoto 
        public ICommand SetServicePhoto { get; }

        private bool CanSetServicePhotoCommand(object p)
        {
            return true;
        }
        private void OnSetServicePhotoCommand(object p)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    RSelectedItem.Phote = openFileDialog.FileName; ///////////////////////////////////////////////////////////////
                }
                catch
                {
                    MessageBox.Show("Выберите файл подходящего формата.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        #endregion

        #endregion

        public AdminPanelViewModel()
        {
            ShowCouchesPanel = new RelayCommand(OnShowCouchesPanelCommand, CanShowCouchesPanelCommand);

            SetServicePhoto = new RelayCommand(OnSetServicePhotoCommand, CanSetServicePhotoCommand);

            RemoveService = new RelayCommand(OnRemoveServiceCommand, CanRemoveServiceCommand);

            SelectedServices = new RelayCommand(OnSelectedServicesCommand, CanSelectedServicesCommand);///////////////////////////////////////////////////////////////////////////

            ChangeServicesListVisibility = new RelayCommand(OnChangeServicesListVisibilityCommand, CanChangeServicesListVisibilityCommand);

            ServicesList = new ObservableCollection<Services>();

            AddService = new RelayCommand(OnAddServiceCommand, CanAddServiceCommand);

            AddAbonement = new RelayCommand(OnAddAbonementCommand, CanAddAbonementCommand);
            Deselect = new RelayCommand(OnDeselectCommand, CanDeselectCommand);
            RemoveAbonement = new RelayCommand(OnRemoveAbonementCommand, CanRemoveAbonementCommand);
            SearchAbonementByName = new RelayCommand(OnSearchAbonementByNameCommand, CanSearchAbonementByNameCommand);

            SortAbonementByName = new RelayCommand(OnSortAbonementByNameCommand, CanSortAbonementByNameCommand);

            SetPhoto = new RelayCommand(OnSetPhotoCommand, CanSetPhotoCommand);

            SaveAllChanges = new RelayCommand(OnSaveAllChangesCommand, CanSaveAllChangesCommand);

            ShowAbonementsPanel = new RelayCommand(OnShowAbonementsPanelCommand, CanShowAbonementsPanelCommand);

            ShowOrdersPanel = new RelayCommand(OnShowOrdersPanelCommand, CanShowOrdersPanelCommand);

            ApproveOrder = new RelayCommand(OnApproveOrderCommand, CanApproveOrderCommand);

            //сразу загрузил даынне
            context = new UnitOfWork();

            //заполнил смотрящего
            AbonementsList = new ObservableCollection<Abonements>(context.AbonementRepo.GetAllAbonements());

            SearchedList = new ObservableCollection<Abonements>(context.AbonementRepo.GetAllAbonements());


            //var tempServices = context.ServiceRepo.GetAllServices();

            //if(tempServices != null)
            //    ServicesList = new ObservableCollection<Services>(tempServices);

            ServicesList = new ObservableCollection<Services>(context.ServiceRepo.GetAllServices());

            //на начальном этапе
            SelectedProducts = new Abonements();

            OrdersList = new ObservableCollection<Orders>(context.OrderRepo.GetAllOrder());

            RejectOrder = new RelayCommand(OnRejectOrderCommand, CanRejectOrderCommand);

            //TODO Заполнения списка всех тренеров
            CouchesList = new ObservableCollection<Couches>(context.CoucheRepo.GetAllCouches());

            SearchedCouchesList = new ObservableCollection<Couches>(context.CoucheRepo.GetAllCouches());

            SelectedCouches = new Couches();
        }
    }
}