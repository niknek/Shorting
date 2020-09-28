using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.Store
{
    class BankPaymentStrategy : IPaymentStartegy
    {
        public string Name => nameof(BankPaymentStrategy);

        public string ChoosePaymentMethod()
        {
            return "Your payment via Bank is successfull";
        }

      
    }
}
