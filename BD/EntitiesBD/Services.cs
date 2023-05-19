using FitnessCenter.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BD.EntitiesBD.Repositories
{
    public class Services : ObservableObject
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }

        public string? _phote;
        public string Phote 
        {
            get => _phote;

            set
            {
                _phote = value;
                OnPropertyChanged("Phote");
            }
        }

        public ObservableCollection<Abonements>? _abonements = new ObservableCollection<Abonements>();

        public virtual ObservableCollection<Abonements>? Abonements
        {
            get => _abonements;

            set
            {
                _abonements = value;
                OnPropertyChanged("Abonements");
            }
        }

        //public virtual ICollection<Abonements>? Abonements
        //{
        //    get => _abonements;

        //    set
        //    {
        //        _abonements = value;
        //        OnPropertyChanged("Abonements");
        //    }
        //}

        public ObservableCollection<Couches>? _сouches = new ObservableCollection<Couches>();

        public virtual ObservableCollection<Couches>? Couches
        {
            get => _сouches;

            set
            {
                _сouches = value;
                OnPropertyChanged("Couches");
            }
        }



        public override string ToString()
        {
            return $" {Title} ";
        }
    }
}