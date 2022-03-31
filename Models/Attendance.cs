using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    #region Models
    public class Attendance
    {
        public bool Late { get; set; }
        public double MissingType { get; set; }
        public int UserId { get; set; }
        public int SeanceId { get; set; }
        public int? ProofId { get; set; }

        public virtual  Proof Proof { get; set; }
        public virtual Seance Seance { get; set; }
        public virtual User User { get; set; }
    }
    #endregion
}