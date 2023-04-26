using Merkator.DataBase;
using Merkator.Interfaces;

namespace Merkator.Infrastrucure
{

    internal class TaskManagerGlobal
    {
        IUserProvider _userProvider;
        public void Add(List<TheTask> tasks)
        {
            foreach(var task in tasks) 
            {
                var user = _userProvider.GetUser(task.UserId);
                user.PutTaskAsync(task);
            }
        }
    }
}
