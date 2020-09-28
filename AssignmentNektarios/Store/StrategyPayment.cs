using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.Store
{
    public class StrategyPayment
    {
        int paymentChoice;
        Dictionary<string, IPaymentStartegy> strategyPayment = new Dictionary<string, IPaymentStartegy>();

        public StrategyPayment()
        { }

        public StrategyPayment(int paymentChoice)
        {
            this.paymentChoice=paymentChoice;
            strategyPayment.Add(nameof(BankPaymentStrategy), new BankPaymentStrategy());
            strategyPayment.Add(nameof(CashPaymentStrategy), new CashPaymentStrategy());
            strategyPayment.Add(nameof(DebitCardPaymentStrategy), new DebitCardPaymentStrategy());
        }

       
        public  IPaymentStartegy GetpaymentMethod(int Choice)
        {
            if (Choice == 0)
            {
                Console.WriteLine("You choose Bank payment");
                return strategyPayment[nameof(BankPaymentStrategy)];
            }
            else if (Choice == 1)
            {
                Console.WriteLine("You choose Debit payment");
                return strategyPayment[nameof(DebitCardPaymentStrategy)];
            }
            else
            {
                Console.WriteLine("You choose Cash payment");
                return strategyPayment[nameof(CashPaymentStrategy)];
            }

        }

    }
}
