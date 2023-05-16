using FitnessCenter.BD.EntitiesBD;
using FitnessCenter.Helpers;
using FitnessCenter.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FitnessCenter.Views.Windows.Main
{
    /// <summary>
    /// Interaction logic for MainCoreD.xaml
    /// </summary>
    public partial class MainCoreD : Window
    {
        public MainCoreD(Clients client)
        {
            InitializeComponent();

            this.DataContext = new MainViewModel(client);

            CurrentClient.client = client;
        }


        private void collapsImg_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void closeImg_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
                DragMove();
            }
        }
    }
}
