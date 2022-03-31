using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDesAbsencesv1.Models;
using Ga.ViewModels;

namespace Ga.Factories
{
    class PromotionFactory
    {
        private UserViewModel userVM = new();
        private PromotionViewModel promotionVM = new();
        public PromotionFactory()
        {
            Promotion promotion = new();
            promotion.Label = "CDA 2022-2023";
            promotionVM.store(promotion);
            //userVM.associatePromotion(1, 1);
        }
    }
}
