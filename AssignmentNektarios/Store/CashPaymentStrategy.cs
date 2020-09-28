using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.Store
{
    class CashPaymentStrategy : IPaymentStartegy
    {
        public string Name => nameof(CashPaymentStrategy);

        public string ChoosePaymentMethod()
        {
            return "Your Cash payment is successfull";
        }

    }
}
