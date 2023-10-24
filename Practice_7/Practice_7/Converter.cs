using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    public class Converter
    {
        public Money Convert(Money money, string targetCurrency, int exchangeRate)
        {
            if (money.Currency == targetCurrency)
            {
                // Валюты совпадают, не требуется конвертации.
                return new Money(money.Amount, targetCurrency);
            }
            else
            {
                // Конвертация по заданному курсу.
                decimal convertedAmount = money.Amount * exchangeRate;
                return new Money(convertedAmount, targetCurrency);
            }
        }

        public Money Add(Money money1, Money money2)
        {
            if (money1.Currency == money2.Currency)
            {
                // Одинаковые валюты, можно выполнить сложение.
                decimal totalAmount = money1.Amount + money2.Amount;
                return new Money(totalAmount, money1.Currency);
            }
            else
            {
                // Валюты разные, нельзя выполнить сложение.
                throw new ArgumentException("Cannot add money in different currencies.");
            }
        }
    }
}
