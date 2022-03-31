using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    #region Models
    public class Seance
    {
        public int SeanceId { get; set; }
        public string Datetime { get; set; }
        public string Label { get; set; }
        public int? ClassroomId { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
            = new HashSet<Attendance>();
    }
    #endregion
}
