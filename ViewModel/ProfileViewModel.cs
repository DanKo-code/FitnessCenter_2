﻿using FitnessCenter.BD.EntitiesBD;
using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using FitnessCenter.Views.Windows.Main.UserControls.Abonements;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using FitnessCenter.BD;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenter.ViewModel
{
    class ProfileViewModel : ObservableObject
    {
        private UnitOfWork context;

        #region Accessors (helpers for ui design)

        #region ClientOrder
        private List<Orders> _clientOrders;
        public List<Orders> ClientOrders
        {
            get => _clientOrders;

            set
            {
                if (_clientOrders != value)
                {
                    _clientOrders = value;
                    OnPropertyChanged(nameof(ClientOrders));
                }
            }
        }
        #endregion

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

        public ObservableCollection<BD.EntitiesBD.Abonements> Abonements { get; set; }

        #region AbonementItems
        private List<Orders> _abonementItems;

        public List<Orders> AbonementItems
        {
            get => _abonementItems;

            set
            {
                if (_abonementItems != value)
                {
                    _abonementItems = value;
                    OnPropertyChanged(nameof(AbonementItems));
                }
            }
        }
        #endregion

        #endregion

        #region Commands
        #region SaveAllChanges
        public ICommand SaveAllChanges { get; }

        private bool CanSaveAllChangesCommand(object p)
        {
            return true;
        }
        private void OnSaveAllChangesCommand(object p)
        {
            context.ClientRepo.SaveAllChanges(CurrentClient);
            MessageBox.Show("Все удачно сохранено!");
        }
        #endregion

        #region ReloadOrdersHisory
        public ICommand ReloadOrdersHisory { get; }

        private bool CanReloadOrdersHisoryCommand(object p)
        {
            return true;
        }
        private void OnReloadOrdersHisoryCommand(object p)
        {
            using (BDContext bd = new BDContext())
            {
                ClientOrders = bd.Orders.Include(o => o.Client).Include(o => o.Abonement).Include(o => o.Abonement.Services).Where(x => x.ClientsId == Helpers.CurrentClient.client.Id).ToList();
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    CurrentClient.Photo = openFileDialog.FileName;
                    Helpers.CurrentClient.client.Photo = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Выберите файл подходящего формата.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        #endregion


        #endregion
        public ProfileViewModel(Clients client)
        {
            Abonements = new ObservableCollection<Abonements>();

            SetPhoto = new RelayCommand(OnSetPhotoCommand, CanSetPhotoCommand);

            context = new UnitOfWork();

            CurrentClient = client;
                
            SaveAllChanges = new RelayCommand(OnSaveAllChangesCommand, CanSaveAllChangesCommand);

            ReloadOrdersHisory = new RelayCommand(OnReloadOrdersHisoryCommand, CanReloadOrdersHisoryCommand);

            //AbonementItems = context.OrderRepo.GetAllOrder().Where(x => x.ClientsId == CurrentClient.Id).ToList();

            foreach (BD.EntitiesBD.Orders item in context.OrderRepo.GetAllOrder().Where(x => x.ClientsId == client.Id).ToList())
            {
                Abonements.Add(item.Abonement);
            }

            ClientOrders = context.OrderRepo.GetAllOrder().Where(x => x.ClientsId == client.Id).ToList();

            //AbonementItems = context.OrderRepo.GetAllOrder().FirstOrDefault(x=>x.Id == client.Id).Abonement;

        }
    }
}
