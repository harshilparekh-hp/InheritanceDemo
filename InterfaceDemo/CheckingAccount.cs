using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class CheckingAccount :Bank, IBank
    {

        // you can withdraw as much money as you want.
        public int CheckBalance()
        {
            // return the balance of checking account
            return 0;
        }

        public void Commission()
        {
            throw new NotImplementedException();
        }

        public void DepositeAmount()
        {
            // logic to deposit an amount into checking account with validation
        }

        public void WithdrawAmount()
        {
            // logic to withdraw amount into checking account with validation
        }
    }
}
