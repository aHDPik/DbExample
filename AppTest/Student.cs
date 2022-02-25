using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
        public virtual Group Group { get; set; }
    }
}
