using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDesAbsencesv1.Models;
using System.ComponentModel;
using Ga.Services;

namespace Ga.ViewModels
{
    sealed class UserViewModel : INotifyPropertyChanged
    {

        private User user;
        readonly DB db = new();
        public void Store(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
