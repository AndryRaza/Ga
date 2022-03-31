using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ga.Services;
using GestionDesAbsencesv1.Models;

namespace Ga.ViewModels
{
    class FormerViewModel : ObservableObject
    {
        readonly DB db = new();

        string _userId;
        string _promotionId;
        List<Promotion> _promotions  ;
        public string UserId { get => _userId; set => OnPropertyChanged(ref _userId, value); }
        public string PromotionId { get => _promotionId; set => OnPropertyChanged(ref _promotionId, value); }

        public List<Promotion> Promotions { get => _promotions; set => OnPropertyChanged(ref _promotions, value); }

        public FormerViewModel()
        {
            this._promotions = db.Promotions.OrderBy(b => b.PromotionId).ToList();

        }
        public List<User>  getStudents()
        {
            var result = db.Appartenirs
                .Where(a => a.PromotionId == Int32.Parse(_promotionId))
                .Select(s => new User
                {
                    FirstName = s.User.FirstName,
                    LastName = s.User.LastName
                })
                .ToList();

            return result;
        }

    }
}
