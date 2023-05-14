using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BD.EntitiesBD
{
    public class Couches : ObservableObject
    {
        public Guid Id { get; set; }

        private string _photo;
        public string Photo 
        {
            get => _photo;

            set
            {
                _photo = value;
                OnPropertyChanged("Photo");
            }
        }

        private string _name;
        public string Name
        {
            get => _name;

            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _description;
        public string Description
        {
            get => _description;

            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        private ObservableCollection<Comments> _comments = new ObservableCollection<Comments>();

        public virtual ObservableCollection<Comments> Comments
        {
            get => _comments;

            set
            {
                _comments = value;
                OnPropertyChanged("Comments");
            }
        }


        private ObservableCollection<Services> _services = new ObservableCollection<Services>();
        public virtual ObservableCollection<Services> Services
        {
            get => _services;

            set
            {
                _services = value;
                OnPropertyChanged("Services");
            }
        }


        public bool AbonementsEquals(Couches obj)
        {
            if (
                Id == obj.Id &&
            Name == obj.Name &&
            Description == obj.Description &&
            Photo == obj.Photo
                )
            {
                return true;
            }

            return false;
        }

        public void ResetData(Couches obj)
        {
            Id = obj.Id;
            Name = obj.Name;
            Description = obj.Description;
            Photo = obj.Photo; 
        }
    }
}
