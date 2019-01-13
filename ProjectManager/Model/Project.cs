using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Project
    {
        public Project(string name , DateTime startTime, DateTime endTime )
        {
            Name = name;
            //Workers = workers;
            StartTime = startTime;
            EndTime = endTime;
        }
        public string Name { get; set; }
        //public List<Tuple<Employee, int> Workers { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public bool Ended()
        {
            return DateTime.Now > EndTime;
        }
        public bool Started()
        {
            return DateTime.Now > StartTime;
        }
    }
}
