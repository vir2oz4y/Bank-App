using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    interface IAccount
    {
        void Put(decimal sum);
        decimal Withdraw(decimal sum);
    }
}
