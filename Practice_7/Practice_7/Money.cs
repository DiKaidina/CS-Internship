using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    public class Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        //абсолютно идентично как с классом кошки 
        public static bool operator == (Money money1, Money money2)
        {
            if (ReferenceEquals(money1, null) && ReferenceEquals(money2, null))
                return true;
            if (ReferenceEquals(money1, null) || ReferenceEquals(money2, null)) //ReferenceEquals возвращает true/false
                return false;

            if (money1.Currency != money2.Currency)
                return false;

            return money1.Amount == money2.Amount;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !(money1 == money2);
        }

    }
}
