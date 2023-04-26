using Merkator.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Merkator.Infrastrucure
{
    internal class User : DataBase.User
    {
        private TaskManagerPersonal _taskManger;
        private ICollection<TheTask> _tasks;
        public User()
        {

        }
        public User(ICollection<TheTask> tasks)
        {
            _tasks = tasks;
            _taskManger = new TaskManagerPersonal(tasks);
        }
        internal async Task PutTaskAsync(TheTask task)
        {
            if (_taskManger == null)
            {
                _taskManger = new TaskManagerPersonal(new List<TheTask>());
            }
            await _taskManger.AddAsync(task);
        }
    }
}
