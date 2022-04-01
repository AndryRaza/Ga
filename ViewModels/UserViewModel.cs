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
    sealed class UserViewModel 
    {

        //private User user;
        readonly DB db = new();
        public void Store(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void associatePromotion(int user,int promotion)
        {
            Appartenir apt = new();
            apt.UserId = user;
            apt.PromotionId = promotion;

            db.Appartenirs.Add(apt);
            db.SaveChanges();

        }



    }
}
