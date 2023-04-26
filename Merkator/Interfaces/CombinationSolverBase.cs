using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Merkator.Interfaces
{
    internal abstract class CombinationSolverBase<T> where T: class
    {
        private ICollection<T> _variant;  
        private ICollection<T> _sourceCollection;
        public CombinationSolverBase()
        {
            
        }
        abstract public Task<List<T>> GetFirstAffordableAsync(ICollection<T> collection, T elem);
        abstract public bool IsOk();
    }

}
