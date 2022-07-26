using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Entities
{
    public class UserTask
    {
        public int Task_Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Deadline Deadline { get; set; }
        public DateTime Creation_Date { get; set; }
    }
}
