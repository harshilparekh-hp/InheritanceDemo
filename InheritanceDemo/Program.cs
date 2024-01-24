using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InheritanceDemo
{
    /// <summary>
    /// Inheritance is simply a mechianism of consuming the members that are defined in one class 
    /// from another class.
    /// rule 1 - parent class constructor will be called first whenever you do interitance, then child class constructor
    //  rule 2 - you cannot access the private members of parent class even if you do inheritance.
    //  rule 3 - you can call the methods of parent class only thru objects not reference variable (e.g. ProgramB proReference)
    //  rule 4 - the parent of all the class is (OBJECT class)
    //  rule 5 - use Base() to pass parameter value to the parent class constructor.
    /// </summary>
    internal class Program : ProgramB
    {
        public Program(int number) : base(number) // here base means calling the parent class constructor which is ProgramB(int number)
        {
            Console.WriteLine("Constructor of child class");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            Program program = new Program(100);
            program.Method1();

            ProgramB programReference; // reference variable.

            programReference = program;

            

            Console.WriteLine();

            //Console.WriteLine("AFTER CREATING OBJECT OF OBJECT CLASS");

            //Object obj1 = new object();
            //Console.WriteLine($"obj1 type :{obj1.GetType()}");

            //Program programChild = new Program();



            programReference.Method1();

            Console.ReadKey();

        }
    }
}
