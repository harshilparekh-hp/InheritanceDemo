using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class SpecializedAccount : IBank
    {
        
        public int CheckBalance()
        {
            throw new NotImplementedException();
        }

        public void DepositeAmount()
        {
            throw new NotImplementedException();
        }

        
        // you can withdraw 100,000 amount a day
    }
}
