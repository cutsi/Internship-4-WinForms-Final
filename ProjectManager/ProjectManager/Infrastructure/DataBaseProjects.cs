using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Infrastructure
{
    public static class DataBaseProjects
    {
        public static List<Project> ListProjects = new List<Project>()
        {
            new Project("youtube", new DateTime(2019, 1, 1), new DateTime(2019, 6, 4)),
            new Project("facebook", new DateTime(2014, 5, 4), new DateTime(2015, 6, 4)),
            new Project("google", new DateTime(2020, 5, 4), new DateTime(2020, 6, 4))
        };

        public static Project GetProject(string name)
        {
            foreach (var project in ListProjects)
            {
                if (project.Name == name)
                    return project;
            }

            return null;
        }

        public static bool CheckProjectName(string projectName)
        {
            foreach (var project in ListProjects)
            {
                if (project.Name == projectName)
                    return true;
                
            }
            return false;
        }
    }
}
