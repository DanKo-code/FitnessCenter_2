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
    /// Interaction logic for SelectedCouch.xaml
    /// </summary>
    public partial class SelectedCouch
    {
        public SelectedCouch(FitnessCenter.BD.EntitiesBD.Couches couches)
        {
            InitializeComponent();

            this.DataContext = couches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedCouch = (sender as Button)?.DataContext as FitnessCenter.BD.EntitiesBD.Couches;

            CouchCommentsCore couchComment = new CouchCommentsCore(selectedCouch);
            couchComment.Show();
        }
    }
}
