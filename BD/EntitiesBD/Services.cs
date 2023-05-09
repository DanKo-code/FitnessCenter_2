using FitnessCenter.Core;
using System;
using System.Collections.Generic;
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
        public string Title { get; set; }

        public string _phote;
        public string Phote 
        {
            get => _phote;

            set
            {
                _phote = value;
                OnPropertyChanged("Phote");
            }
        }

public virtual ICollection<Abonements> Abonements { get; set; }

        public override string ToString()
        {
            return $" {Title} ";
        }
    }
}