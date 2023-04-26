using Merkator.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkator.TestArea
{
    internal class Storage
    {
        public List<TheTask> tasks = new List<TheTask>()
        {
            new TheTask() {
                Id = new Guid("1"),
                Deadline = new DateTime(2023,04,30),
                TaskDuration = TimeSpan.FromHours(8),
                Importance = ImportanceType.important,
                UserId = new Guid("1"),             
            },
            new TheTask() {
                Id = new Guid("2"),
                Deadline = new DateTime(2023,05,04),
                TaskDuration = TimeSpan.FromHours(3),
                Importance = ImportanceType.urgent,
                UserId = new Guid("1"),
            },
            new TheTask() {
                Id = new Guid("3"),
                Deadline = new DateTime(2023,05,03),
                TaskDuration = TimeSpan.FromHours(35),
                Importance = ImportanceType.important,
                UserId = new Guid("2"),
            },
        };
    }
}
