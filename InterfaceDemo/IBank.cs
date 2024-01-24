using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

    /// <summary>
    /// Interface is a contract which we enforce to all the classes who are going to implement/extend
    /// rule 1: by default all the new interface and its members is public if we dont specify the access modifier.
    /// rule 2: you should not implement the members of interface in interface only. keep it abstract.
    /// rule 3: we cannot declare variables/fields, constructors and destructors in interface.
    /// rule 4: all the child class of an interface must implement the members. (mandatory)
    /// 
    /// we can implement multiple inheritance using class and interface. 
    /// (here, please remember we can implement multiple interfaces too)
    /// </summary>

    interface IBank
    {
        //int balance;
        void WithdrawAmount();

        void DepositeAmount();

        int CheckBalance();
      
    }
}
