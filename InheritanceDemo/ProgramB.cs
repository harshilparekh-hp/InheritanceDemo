using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class ProgramB
    {

        //public ProgramB()
        //{
        //    Console.WriteLine("Constructor of the parent class");
        //}

        public ProgramB(int paramInt)
        {
            Console.WriteLine("Parameter of the parent class constructor is : {0}", paramInt);
        }

        string strProgramB;

        // going to be accessed in Program class due to inheritance.
        public int programBVariable; 
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2");
        }


    }
}
