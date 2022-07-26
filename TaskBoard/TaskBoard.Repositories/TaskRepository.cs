using Dapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoard.DI;
using TaskBoard.Entities;

namespace TaskBoard.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ILogger<TaskRepository> _logger;
        private readonly DBOptions _dBOptions;
        public TaskRepository(DBOptions dBOptions, ILogger<TaskRepository> logger) 
        {
            _logger = logger;
            _dBOptions = dBOptions;
        }
        public async Task<IEnumerable<UserTask>> GetUserTasksById(int userId)
        {
            using (IDbConnection db = new SqlConnection(_dBOptions.ConnectionString)) 
            {
                var tasks = db.Query<UserTask, Deadline, Category, UserTask>("GetUserTasksById",
                    (task, deadline, category) => { task.Deadline = deadline; task.Category = category; return task; });
                return tasks;
            }
        }
    }
}
