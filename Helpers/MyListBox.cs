using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.BD.EntitiesBD;
using System.ComponentModel;
using FitnessCenter.ViewModel;
using System.Windows.Input;

namespace FitnessCenter.Helpers
{
    public class MyListBox : ListBox
    {
        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register("SelectedItems", typeof(ICollection<Services>), typeof(MyListBox),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public ICollection<Services> SelectedItems
        {
            get 
            {
                return (ICollection<Services>)GetValue(SelectedItemsProperty); 
            }
            set 
            {
                SetValue(SelectedItemsProperty, value); 
            }
        }

        /// <summary>

        public static readonly DependencyProperty RSelectedItemProperty =
            DependencyProperty.Register("RSelectedItem", typeof(Services), typeof(MyListBox),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Services RSelectedItem
        {
            get { return (Services)GetValue(RSelectedItemProperty); }
            set { SetValue(RSelectedItemProperty, value); }
        }

        //чтобы при нажатии правой км не выбиралась услуга
        protected override void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e)
        {
            Services temp = new Services();

            try
            {
                temp = (Services)((System.Windows.Controls.Border)e.OriginalSource).DataContext;
            }
            catch
            {
                MessageBox.Show("Такой услуги нет ни в одном абонементе!");
                e.Handled = true;
            }
            

            RSelectedItem = temp;

            //SelectedItem = ItemContainerGenerator.ItemFromContainer((DependencyObject)e.OriginalSource);
            e.Handled = true;
        }

        /// </summary>
        /// <param name="e"></param>


        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);
            if(e.AddedItems.Count != 0)
            {
                foreach (Services item in e.AddedItems)
                {
                    if (SelectedItems.Contains(item))
                        return;
                    SelectedItems.Add(item);
                }
                SelectedItems = SelectedItems;
            }

            if(e.RemovedItems.Count != 0)
            {
                foreach (Services item in e.RemovedItems)
                {
                    SelectedItems.Remove(item);
                }
                SelectedItems = SelectedItems;
            }
            

        }

        public MyListBox()
        {
            AdminPanelViewModel.MyEvent += OtherClass_MyEvent;
        }

        private void OtherClass_MyEvent(object sender, EventArgs e)
        {

            this.SetSelectedItems(SelectedItems);
        }
    }
}
