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
    /// Interaction logic for Couches.xaml
    /// </summary>
    public partial class Couches : UserControl
    {
        public Couches()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SelectedCoachProperty = DependencyProperty.Register(
    "SelectedCoach", typeof(FitnessCenter.BD.EntitiesBD.Couches), typeof(SelectedCouch), new PropertyMetadata(null));

        public FitnessCenter.BD.EntitiesBD.Couches SelectedCoach
        {
            get { return (FitnessCenter.BD.EntitiesBD.Couches)GetValue(SelectedCoachProperty); }
            set { SetValue(SelectedCoachProperty, value); }
        }
    }
}
