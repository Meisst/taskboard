using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Entities
{
    public class User
    {
        public int User_Id { get; set; }
        public string Name { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
    }
}
