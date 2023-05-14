using FitnessCenter.BD.EntitiesBD;
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

namespace FitnessCenter.ViewModel
{
    class ProfileViewModel : ObservableObject
    {
        private UnitOfWork context;

        #region Accessors (helpers for ui design)

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
            AbonementItems = context.OrderRepo.GetAllOrder().Where(x => x.ClientsId == CurrentClient.Id).ToList();
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
            SetPhoto = new RelayCommand(OnSetPhotoCommand, CanSetPhotoCommand);

            context = new UnitOfWork();

            CurrentClient = client;

            SaveAllChanges = new RelayCommand(OnSaveAllChangesCommand, CanSaveAllChangesCommand);

            ReloadOrdersHisory = new RelayCommand(OnReloadOrdersHisoryCommand, CanReloadOrdersHisoryCommand);

            AbonementItems = context.OrderRepo.GetAllOrder().Where(x => x.ClientsId == CurrentClient.Id).ToList();
        }
    }
}
