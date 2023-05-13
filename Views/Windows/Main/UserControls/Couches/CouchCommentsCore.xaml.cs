using FitnessCenter.BD;
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
        }
    }
}
