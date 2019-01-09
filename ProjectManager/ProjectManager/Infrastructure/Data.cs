using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Enums;

namespace Infrastructure
{
    public static class Data
    {
        //2 liste i povezivanje
        public static List<Employee> AllEmployees = new List<Employee>();
        public static List<Project> AllProjects = new List<Project>();

        public static List<Tuple<Employee, Project, int>> link = new List<Tuple<Employee, Project, int>>();

        public static bool AddEmployeeToProject(Employee e, Project p, int h)
        {
            link.Add(new Tuple<Employee, Project, int>(e, p, h));
            return true;
        }

        public static void Init()
        {
            var emp1 = new Employee("Mate", "Matic", new DateTime(1994, 12, 6), "12345678901", Position.Programmer);
            var emp2 = new Employee("Mate", "Matic", new DateTime(1994, 12, 6), "12345678901", Position.Programmer);

           

            AllEmployees.Add(new Employee("Mate", "Matic", new DateTime(1994,12,6), "12345678901", Position.Programmer));
            AllEmployees.Add(new Employee("Mate", "Matic", new DateTime(1994, 12, 6), "12345678901", Position.Programmer));
            AllEmployees.Add(new Employee("Mate", "Matic", new DateTime(1994, 12, 6), "12345678901", Position.Programmer));
            AllEmployees.Add(new Employee("Mate", "Matic", new DateTime(1994, 12, 6), "12345678901", Position.Programmer));


            AllProjects.Add(new Project("FakeBook",new List<Tuple<Employee , int >>() {new Tuple<Employee, int>( emp2,4),
                    new Tuple<Employee, int>(emp1, 4) } , DateTime.Now, DateTime.Today ));
            AllProjects.Add(new Project("FaceBook", new List<Tuple<Employee, int>>() {new Tuple<Employee, int>( emp2,4),
                new Tuple<Employee, int>(emp1, 4) }, DateTime.Now, DateTime.Today));
        }
       
    }
}
