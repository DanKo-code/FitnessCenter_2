using FitnessCenter.BD.EntitiesBD.Repositories;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FitnessCenter.Views.Windows.Main.UserControls.Couches
{
    /// <summary>
    /// Interaction logic for CouchItem.xaml
    /// </summary>
    /// 

    public partial class CouchItem : UserControl
    {
        UnitOfWork context;

        public CouchItem()
        {
            InitializeComponent();

            context = new UnitOfWork();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedCouch = (sender as Button)?.DataContext as FitnessCenter.BD.EntitiesBD.Couches;
            SelectedCouch selectedCouchW = new SelectedCouch(selectedCouch);
            selectedCouchW.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedCouch = (sender as Button)?.DataContext as FitnessCenter.BD.EntitiesBD.Couches;

            SendCouchComment couchComment = new SendCouchComment(selectedCouch);
            couchComment.Show();
        }
    }
}
