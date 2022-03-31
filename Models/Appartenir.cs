using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    #region Models
    public class Appartenir
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int PromotionId { get; set; }
        public virtual Promotion Promotion { get; set; }
        public bool? Archived { get; set; }
    }
    #endregion
}
