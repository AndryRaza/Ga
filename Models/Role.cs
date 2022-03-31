using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    #region Models
    public class Role
    {
        public int RoleId { get; set; }

        public string Label { get; set; }

        public virtual ICollection<User> Users { get; set; }
         = new HashSet<User>();
    }
    #endregion
}
