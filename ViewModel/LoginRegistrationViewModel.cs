using FitnessCenter.BD;
using FitnessCenter.BD.EntitiesBD;
using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using FitnessCenter.Helpers;
using FitnessCenter.Views.Windows.LoginRegistration;
using FitnessCenter.Views.Windows.Main;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;

namespace FitnessCenter.ViewModel
{
    internal class LoginRegistrationViewModel : ObservableObject
    {
        private UnitOfWork context;

        #region Accessors (helpers for ui design)

        //For Register
        #region ErrorPhone
        private Brush _errorPhone = Brushes.White;

        public Brush ErrorPhone
        {
            get => _errorPhone;

            set
            {
                if (_errorPhone != value)
                {
                    _errorPhone = value;
                    OnPropertyChanged("ErrorPhone");
                }
            }
        }
        #endregion

        #region ErrorEmail
        private Brush _errorEmail = Brushes.White;

        public Brush ErrorEmail
        {
            get => _errorEmail;

            set
            {
                if (_errorEmail != value)
                {
                    _errorEmail = value;
                    OnPropertyChanged("ErrorEmail");
                }
            }
        }
        #endregion

        #region ErrorPass
        private Brush _errorPass = Brushes.White;

        public Brush ErrorPass
        {
            get => _errorPass;

            set
            {
                if (_errorPass != value)
                {
                    _errorPass = value;
                    OnPropertyChanged("ErrorPass");
                }
            }
        }
        #endregion

        #region ErrorLogin
        private Brush _errorLogin = Brushes.White;

        public Brush ErrorLogin
        {
            get => _errorLogin;

            set
            {
                if (_errorLogin != value)
                {
                    ErrorBoxVisibility = Visibility.Collapsed;
                    _errorLogin = value;
                    OnPropertyChanged("ErrorLogin");
                }
            }
        }
        #endregion

        #region ErrorLastName
        private Brush _errorLastName = Brushes.White;

        public Brush ErrorLastName
        {
            get => _errorLastName;

            set
            {
                if (_errorLastName != value)
                {
                    _errorLastName = value;
                    OnPropertyChanged("ErrorLastName");
                }
            }
        }
        #endregion

        #region ErrorName
        private Brush _errorName = Brushes.White;

        public Brush ErrorName
        {
            get => _errorName;

            set
            {
                if (_errorName != value)
                {
                    _errorName = value;
                    OnPropertyChanged("ErrorName");
                }
            }
        }
        #endregion

        #region ErrorBorderPassword
        private Brush _errorBorderPassword = Brushes.White;

        public Brush ErrorBorderPassword
        {
            get => _errorBorderPassword;

            set
            {
                if (_errorBorderPassword != value)
                {
                    _errorBorderPassword = value;
                    OnPropertyChanged(nameof(ErrorBorderPassword));
                }
            }
        }
        #endregion

        #region ErrorBorderLogin
        private Brush _errorBorderLogin = Brushes.White;

        public Brush ErrorBorderLogin
        {
            get => _errorBorderLogin;

            set
            {
                if (_errorBorderLogin != value)
                {
                    _errorBorderLogin = value;
                    OnPropertyChanged(nameof(ErrorBorderLogin));
                }
            }
        }
        #endregion

        #region ErrorBoxVisibility
        private Visibility _errorBoxVisibility = Visibility.Collapsed;

        public Visibility ErrorBoxVisibility
        {
            get => _errorBoxVisibility;

            set
            {
                if (_errorBoxVisibility != value)
                {
                    _errorBoxVisibility = value;
                    OnPropertyChanged(nameof(ErrorBoxVisibility));
                }
            }
        }
        #endregion

        #region ErrorText
        private string _errorText;

        public string ErrorText
        {
            get => _errorText;

            set
            {
                if (_errorText != value)
                {
                    _errorText = value;
                    OnPropertyChanged(nameof(ErrorText));
                }
            }
        }
        #endregion


        #region SignInLogin
        private string _signInLogin;

        public string SignInLogin
        {
            get => _signInLogin;

            set
            {
                if (_signInLogin != value)
                {
                    ErrorBoxVisibility = Visibility.Collapsed;
                    ErrorBorderLogin = Brushes.White;
                    ErrorBorderPassword = Brushes.White;

                    _signInLogin = value;
                    OnPropertyChanged(nameof(SignInLogin));
                }
            }
        }
        #endregion

        #region SignInPassword
        private string _signInPassword;

        public string SignInPassword
        {
            get => _signInPassword;

            set
            {
                if (_signInPassword != value)
                {
                    ErrorBoxVisibility = Visibility.Collapsed;
                    ErrorBorderLogin = Brushes.White;
                    ErrorBorderPassword = Brushes.White;

                    _signInPassword = value;
                    OnPropertyChanged(nameof(SignInPassword));
                }
            }
        }
        #endregion

        #region SignInPasswordSecure
        private System.Security.SecureString _signInPasswordSecure;

        public System.Security.SecureString SignInPasswordSecure
        {
            get => _signInPasswordSecure;

            set
            {
                if (_signInPasswordSecure != value)
                {
                    _signInPasswordSecure = value;
                    OnPropertyChanged(nameof(SignInPasswordSecure));
                }
            }
        }
        #endregion

        #region NewClient
        //public Clients _newClient = new Clients("", "", "", "", "", "");
        public Clients _newClient = new Clients { Id = new Guid(), Email = "", Login = "", Name = "", Password = "", Phone = "", Role = 0, SurName = "",
            Photo = "D:\\2k2s\\OOP_MY\\Курсач\\моя залупа\\Работал MyListBox и delete\\Test\\FintessCenter-08b29904dd9b128bdfdea8ffc3c463cad2e1991c\\Resources\\Images\\PhotoMssing.png" };

        public Clients NewClient
        {
            get => _newClient;

            set
            {
                if (_newClient != value)
                {
                    _newClient = value;
                    OnPropertyChanged(nameof(NewClient));
                }
            }
        }

        #endregion

        #region LoginVisibility
        private Visibility _loginVisibility = Visibility.Visible;

        public Visibility LoginVisibility
        {
            get => _loginVisibility;

            set
            {
                if (_loginVisibility != value)
                {
                    _loginVisibility = value;
                    OnPropertyChanged(nameof(LoginVisibility));
                }
            }
        }
        #endregion

        #region RegisterVisibility
        private Visibility _registerVisibility = Visibility.Collapsed;

        public Visibility RegisterVisibility
        {
            get => _registerVisibility;

            set
            {
                if (_registerVisibility != value)
                {
                    _registerVisibility = value;
                    OnPropertyChanged(nameof(RegisterVisibility));
                }
            }
        }
        #endregion

        //Для регистрации

        #region RegisterNameStyle
        private Brush _registerNameStyle;

        public Brush RegisterNameStyle
        {
            get => _registerNameStyle;

            set
            {
                if (_registerNameStyle != value)
                {
                    _registerNameStyle = value;
                    OnPropertyChanged(nameof(RegisterNameStyle));
                }
            }
        }
        #endregion

        #endregion

        #region Commands

        #region ShowLogin
        public ICommand ShowLoginCommand { get; }

        private bool CanShowLoginCommand(object p) => true;

        private void OnShowLoginCommand(object p)
        {
            LoginVisibility = Visibility.Visible;
            RegisterVisibility = Visibility.Collapsed;
        }
        #endregion

        #region ShowRegister
        public ICommand ShowRegisterCommand { get; }

        private bool CanShowRegisterCommand(object p) => true;

        private void OnShowRegisterCommand(object p)
        {
            LoginVisibility = Visibility.Collapsed;
            RegisterVisibility = Visibility.Visible;
        }
        #endregion

        private void GoMain(Clients client)
        {
            CurrentClient.client = client;

            Main main = new Main(client);
            main.Show();

            foreach (Window window in Application.Current.Windows)
            {
                if (window is LoginRegisterCoreD)
                {
                    window.Close();
                    break;
                }
            }

        }

        //Для регистрации////////////////////////////////////////////////////////////////

        #region CheckPhone
        public ICommand CheckPhone { get; }

        private bool CanCheckPhoneCommand(object p) => true;

        private void OnCheckPhoneCommand(object p)
        {


            if (!Regex.IsMatch(NewClient.Phone, "^\\+375(17|25|29|33|44)\\d{7}$"))
            {
                ErrorPhone = Brushes.Red;
                return;
            }

            ErrorPhone = Brushes.White;
        }
        #endregion

        #region CheckEmail
        public ICommand CheckEmail { get; }

        private bool CanCheckEmailCommand(object p) => true;

        private void OnCheckEmailCommand(object p)
        {


            if (!Regex.IsMatch(NewClient.Email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
            {
                ErrorEmail = Brushes.Red;
                return;
            }

            ErrorEmail = Brushes.White;
        }
        #endregion

        #region CheckPass
        public ICommand CheckPass { get; }

        private bool CanCheckPassCommand(object p) => true;

        private void OnCheckPassCommand(object p)
        {


            if (!Regex.IsMatch(NewClient.Password, "^[a-zA-Z0-9]{6,12}$"))
            {
                ErrorPass = Brushes.Red;
                return;
            }

            ErrorPass = Brushes.White;
        }
        #endregion

        #region CheckLogin
        public ICommand CheckLogin { get; }

        private bool CanCheckLoginCommand(object p) => true;

        private void OnCheckLoginCommand(object p)
        {


            if (!Regex.IsMatch(NewClient.Login, "^[a-zA-Z0-9_-]{3,16}$"))
            {
                ErrorLogin = Brushes.Red;
                return;
            }

            ErrorLogin = Brushes.White;
        }
        #endregion

        #region CheckLastName
        public ICommand CheckLastName { get; }

        private bool CanCheckLastNameCommand(object p) => true;

        private void OnCheckLastNameCommand(object p)
        {


            if (!Regex.IsMatch(NewClient.SurName, "^[A-Za-zА-Яа-я]+$"))
            {
                ErrorLastName = Brushes.Red;
                return;
            }

            ErrorLastName = Brushes.White;
        }
        #endregion

        #region CheckName
        public ICommand CheckName { get; }

        private bool CanCheckNameCommand(object p) => true;

        private void OnCheckNameCommand(object p)
        {


            if (!Regex.IsMatch(NewClient.Name, "^[A-Za-zА-Яа-я]+$"))
            {
                ErrorName = Brushes.Red;
                return;
            }

            ErrorName = Brushes.White;
        }
        #endregion

        #region Register
        public ICommand Register { get; }

        private bool CanRegisterCommand(object p)
        {
            if(ErrorName == Brushes.White && NewClient.Name.Length>0 &&
                ErrorLastName == Brushes.White && NewClient.SurName.Length>0 &&
                ErrorLogin == Brushes.White && NewClient.Login.Length>0 &&
                ErrorPass == Brushes.White && NewClient.Password.Length>0 &&
                ErrorEmail == Brushes.White && NewClient.Email.Length>0 &&
                ErrorPhone == Brushes.White && NewClient.Phone.Length>0)
            return true;

            return false;
        }

        private void OnRegisterCommand(object p)
        {
            if(context.ClientRepo.CheckLogin(NewClient.Login))
            {
                ErrorText = "Пользователь с таким логином уже зарегистрирован!";
                ErrorBoxVisibility = Visibility.Visible;
                return;
            }

            context.ClientRepo.AddClient(NewClient);

            //TODO Проверка, есть ли такой логин в бд или нет

            OnShowLoginCommand(null);
        }
        #endregion

        #region SignIn
        public ICommand SignIn { get; }

        private bool CanSignInCommand(object p) => true;

        private void OnSignInCommand(object p)
        {
            Clients temp;

            string tempStrPass;

            if (SignInPassword == null || SignInPassword.Length == 0)
            {
                tempStrPass = Helpers.CurrentClient.securePassBox;
            }
            else
            {
                tempStrPass = SignInPassword;
            }
            

            
            
            
            
            
   
            if (!context.ClientRepo.CheckLogin(SignInLogin))
            {
                ErrorText = "Неверный логин!";

                ErrorBoxVisibility = Visibility.Visible;

                ErrorBorderLogin = Brushes.Red;

                return;
            }

            temp = context.ClientRepo.CheckPassword(SignInLogin, tempStrPass);

            if (temp == null)
            {
                ErrorText = "Неверный пароль!";

                ErrorBoxVisibility = Visibility.Visible;

                ErrorBorderPassword = Brushes.Red;

                return;
            }

            GoMain(temp);
        }
        #endregion

        
        #endregion

        public LoginRegistrationViewModel()
        {
            //for registration
            CheckPhone = new RelayCommand(OnCheckPhoneCommand, CanCheckPhoneCommand);
            CheckEmail = new RelayCommand(OnCheckEmailCommand, CanCheckEmailCommand);
            CheckPass = new RelayCommand(OnCheckPassCommand, CanCheckPassCommand);
            CheckLogin = new RelayCommand(OnCheckLoginCommand, CanCheckLoginCommand);
            CheckLastName = new RelayCommand(OnCheckLastNameCommand, CanCheckLastNameCommand);

            ShowLoginCommand = new RelayCommand(OnShowLoginCommand, CanShowLoginCommand);
            ShowRegisterCommand = new RelayCommand(OnShowRegisterCommand, CanShowRegisterCommand);
            

            //Проверка валидности при регистрации

            CheckName = new RelayCommand(OnCheckNameCommand, CanCheckNameCommand);

            //Сама регистрация
            Register = new RelayCommand(OnRegisterCommand, CanRegisterCommand);

            context = new UnitOfWork();

            //Для входа

            SignIn = new RelayCommand(OnSignInCommand, CanSignInCommand);

            Helpers.CurrentClient.abonements = context.AbonementRepo.GetAllAbonements();

        }
    }
}
