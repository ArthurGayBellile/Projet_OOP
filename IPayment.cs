using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_OOP
{
    interface IPayment
    {
        int ToBePaid { get; set; }
        int NumberOfPayments { get; set; }

    }

}
