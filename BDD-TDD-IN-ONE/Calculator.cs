using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_TDD_IN_ONE
{
   
    public class Calculator  
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }

        public int Add()
        {
            Result = FirstNumber + SecondNumber;
            return Result;
        }

        
    }
   
}
