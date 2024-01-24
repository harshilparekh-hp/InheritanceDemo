using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program : CheckingAccount
    {
        static void Main(string[] args)
        {

            // one way to call the implemented methods in child class from interface - class object
            CheckingAccount ca = new CheckingAccount();
            ca.Commission();
            ca.CheckBalance();

            // second way to call the methods exist in interface and class 
            IBank iBankreference = new CheckingAccount();
            iBankreference.CheckBalance();
            



        }
    }
}
