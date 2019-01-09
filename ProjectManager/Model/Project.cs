using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Project
    {
        public Project(string name, List <Tuple<Employee, int>> workers, DateTime startTime, DateTime endTime )
        {
            Name = name;
            Workers = workers;
            StarTime = startTime;
            EndTime = endTime;
        }
        public string Name { get; set; }
        public List<Tuple<Employee, int>> Workers { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
