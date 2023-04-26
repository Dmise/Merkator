using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merkator.DataBase;
using Merkator.Interfaces;

namespace Merkator.Infrastrucure
{
    /// <summary>
    /// Distribute task within users
    /// </summary>
    internal class TaskManagerPersonal
    {
        private ICollection<TheTask> _taskList;     
        private CombinationSolverBase<TheTask> _combinationSolver;
        public TaskManagerPersonal(ICollection<TheTask> task)
        {
            _taskList= task;
            
        }
        public async Task AddAsync(TheTask task)
        {           
            await Insert(task);
        }
       
        private async Task Insert(TheTask task)
        {
            // queue logic           
            await _combinationSolver.GetFirstAffordableAsync(_taskList ,task);
        }
    }
}
