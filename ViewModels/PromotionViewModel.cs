using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDesAbsencesv1.Models;
using Ga.Services;

namespace Ga.ViewModels
{
    class PromotionViewModel
    {

        readonly DB db = new();

        public Promotion store(Promotion promotion)
        {
            db.Promotions.Add(promotion);
            db.SaveChanges();

            return promotion;
        }
    }
}
