using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkator.DataBase
{
    internal class TheTask : IBaseEntity
    {
        public Guid Id { get; set; }
        public TimeSpan TaskDuration { get; set; }
        public DateTime Deadline { get; set; }
        public Guid UserId { get; set; }
        public ImportanceType Importance { get; set; }
    }
}
