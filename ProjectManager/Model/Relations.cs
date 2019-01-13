using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Relations
    {
        ///project name oib hours
        public Relations(string oib, string projectName, string hours)
        {
            Oib = oib;
            ProjectName = projectName;
            Hours = hours;
        }
        public Relations(string oib, string projectName)
        {
            Oib = oib;
            ProjectName = projectName;
            
        }

        //2 liste i povezivanje
        public string Oib { get; set; }
        public string ProjectName { get; set; }
        public string Hours { get; set; }

        
    }
}
