using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.Store
{
    class DebitCardPaymentStrategy : IPaymentStartegy
    {
        public string Name => nameof(DebitCardPaymentStrategy);

        public string ChoosePaymentMethod()
        {
            return "Your payment with the debit card was succeed";
        }

    }
}
