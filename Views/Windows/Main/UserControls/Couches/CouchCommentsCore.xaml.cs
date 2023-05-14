using FitnessCenter.BD;
using FitnessCenter.BD.EntitiesBD;
using FitnessCenter.BD.EntitiesBD.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for CouchComment.xaml
    /// </summary>
    public partial class CouchCommentsCore 
    {
        private BDContext context;

        public CouchCommentsCore(FitnessCenter.BD.EntitiesBD.Couches couches)
        {
            InitializeComponent();

            context = new BDContext();

            DataContext = context.Couches.FirstOrDefault(x=>x.Id == couches.Id);

            //MyListView.ItemsSource = ((FitnessCenter.BD.EntitiesBD.Couches)DataContext).Comments

            ObservableCollection<Comments> tempList = context.Couches.Where(x => x.Id == couches.Id).Include(x => x.Comments).ToList()[0].Comments;

            List<Comments> tempFullComments = new List<Comments>();

            foreach (Comments item in tempList)
            {
                tempFullComments.Add(context.Comments.Where(x => x.Id == item.Id).Include(x=>x.Clients).First());
            }

            

            MyListView.ItemsSource = tempFullComments;
        }
    }
}
