using FitnessCenter.BD;
using FitnessCenter.BD.EntitiesBD;
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
    /// Interaction logic for SendCouchComment.xaml
    /// </summary>
    public partial class SendCouchComment
    {
        private UnitOfWork context;

        public SendCouchComment(FitnessCenter.BD.EntitiesBD.Couches couches)
        {
            DataContext = couches;

            context = new UnitOfWork();

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (UnitOfWork context = new UnitOfWork())
            {
                FitnessCenter.BD.EntitiesBD.Couches tempCouches = context.CoucheRepo.GetAllCouches().FirstOrDefault(x => x.Id == ((FitnessCenter.BD.EntitiesBD.Couches)DataContext).Id);
                FitnessCenter.BD.EntitiesBD.Clients tempClients = context.ClientRepo.GetAllClients().FirstOrDefault(x => x.Id == Helpers.CurrentClient.client.Id);

                context.CommentsRepo.AddComments(new Comments() { Id = new Guid(), Couches = tempCouches, CommentBody = CommentBody.Text, Clients = tempClients });
                Close();


            }




        }
    }
}
