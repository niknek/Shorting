using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.Store
{
    public interface IPaymentStartegy
    {
        string Name { get; }
        string ChoosePaymentMethod();
    }
}
