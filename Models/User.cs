using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    #region Models
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Appartenir> Appartenirs { get; set; }
            = new HashSet<Appartenir>();
        public virtual ICollection<Attendance> Attendances { get; set; }
            = new HashSet<Attendance>();
    }
    #endregion
}
