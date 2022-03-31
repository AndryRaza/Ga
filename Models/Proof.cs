using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    #region Models
    public class Proof
    {
        public int ProofId { get; set; }
        public bool? Justify { get; set; }
        public string Comment { get; set; }
        public string Motive { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
            = new HashSet<Attendance>();
    }
    #endregion
}
