using Merkator.Infrastrucure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkator.Interfaces
{
    internal interface IUserProvider
    {
        User GetUser(Guid id);
                        
    }
}
