using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public class Employee
    {
        
        public Employee(string firstName, string lastName, DateTime dateOfBirth, string oib, Position position)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Oib = oib;
            Position = position;
        }
 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Oib { get; set; }
        public Position Position { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Oib;
        }
        public  bool CheckIfAdult()
        {
            return DateTime.Now.Year - DateOfBirth.Year >= 18;
        }
    }

}
