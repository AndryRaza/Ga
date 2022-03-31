using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    #region Models
    public class Promotion
    {
        public int PromotionId { get; set; }
        public string Label { get; set; }

        public virtual ICollection<Appartenir> Appartenirs { get; set; }
            = new HashSet<Appartenir>();
    }
    #endregion
}
