using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Enums;

namespace Infrastructure
{
    public class DataBaseEmployees
    {
        public static List<Employee> ListEmployees = new List<Employee>()
        {
            new Employee("ivan", "ivic", new DateTime(1995, 5, 4), "65465407751", Position.Programmer),
            new Employee("mate", "ivic", new DateTime(1995, 5, 4), "65465404684", Position.Accountant),
            new Employee("ante", "ivic", new DateTime(1995, 5, 4), "65465405456", Position.Secretary)
        };
        //dobit po oibu ciloga emploija 

        

        public static Employee GetEmployee(string oib)
        {
            foreach (var emp in ListEmployees)
            {
                if (emp.Oib == oib)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}
