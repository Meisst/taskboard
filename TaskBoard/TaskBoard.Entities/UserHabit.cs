using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Entities
{
    public class UserHabit
    {
        public int Habit_Id { get; set; }
        public string Name { get; set; }
        public int InRow { get; set; }
        public DateTime Creation_Date { get; set; }
    }
}
