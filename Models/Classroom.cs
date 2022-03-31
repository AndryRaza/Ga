using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    #region Models
    public class Classroom
    {
        public int ClassroomId { get; set; }
        public string Label { get; set; }

        public virtual ICollection<Seance> Seances { get; set; }
             = new HashSet<Seance>();
    }
    #endregion
}
