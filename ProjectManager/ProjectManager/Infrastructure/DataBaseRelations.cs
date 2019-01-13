using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Enums;

namespace Infrastructure
{
    public static class DataBaseRelations
    {
        public static List<Relations> RelationList = new List<Relations>()
        {
            new Relations("65465404684", "youtube", "10"),
            new Relations("65465407751", "facebook", "20"),
            new Relations("65465405456", "google", "30")
        };

        public static List<Project> GetEmployeesProjects(string oib)
        {
            var projectList = new List<Project>();
            foreach (var relation in RelationList)
            {
                if (relation.Oib == oib)
                {
                    projectList.Add(DataBaseProjects.GetProject(relation.ProjectName));
                }
            }

            return projectList;
        }

        public static List<Relations> GetEmployeeRelations(string oib)
        {
            var relationList = new List<Relations>();
            foreach (var relation in RelationList)
            {
                if (relation.Oib == oib)
                {
                    relationList.Add(relation);
                }
            }

            return relationList;
        }

        public static int GetHours(string oib)
        {
            var hours = 0;
            foreach (var item in GetEmployeeRelations(oib))
            {
                
                if(DataBaseProjects.GetProject(item.ProjectName).Started() && !DataBaseProjects.GetProject(item.ProjectName).Ended())
                    hours += int.Parse(item.Hours);
            }

            return hours;
        }
    }
     
}



/*var emp1 = new Employee("Mate", "Matic", new DateTime(1994, 12, 6), "12345678901", Position.Programmer);
            var emp2 = new Employee("Ante", "Antic", new DateTime(1995, 12, 6), "12345678902", Position.Programmer);

            AllEmployees.Add(emp1);
            AllEmployees.Add(emp2);

            AllProjects.Add(new Project("FakeBook" , DateTime.Now, DateTime.Today ));
            AllProjects.Add(new Project("FaceBook",  DateTime.Now, DateTime.Today));

    public static List<Employee> AllEmployees = new List<Employee>();
        public static List<Project> AllProjects = new List<Project>();

        public static List<Tuple<Employee, Project, int>> link = new List<Tuple<Employee, Project, int>>();

        public static bool AddEmployeeToProject(Employee e, Project p, int h)
        {
            link.Add(new Tuple<Employee, Project, int>(e, p, h));
            return true;
        }
*/
