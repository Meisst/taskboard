using System.Collections.Generic;
using System.Threading.Tasks;
using TaskBoard.Entities;

namespace TaskBoard.DI
{
    public interface ITaskRepository
    {
        Task<IEnumerable<UserTask>> GetUserTasksById(int userId);
    }
}
