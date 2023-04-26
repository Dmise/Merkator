using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkator.DataBase
{
    internal class User : IBaseEntity
    {
        
        public Guid Id { get; set; }
        DateTime StartSesion { get; set; }
        DateTime EndSession { get; set; }
        public virtual ICollection<TheTask>? Tasks { get; set; }
    }
}
