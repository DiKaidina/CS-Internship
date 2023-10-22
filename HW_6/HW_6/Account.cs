using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Account
{
    public class Account
    {
        private string AccountNumber { get; set; }
        private decimal Balance { get; set; }
        private string Password { get; set; }

        public Account(string AccountNumber, decimal Balance, string Password)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.Password = Password;
        }
        //получить номер счета
        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        //получить пароль
        public string GetPassword()
        {
            return Password;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
        public string RefillAccount(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return $"На счёт {AccountNumber} зачислено {amount} тенге. Новый баланс: {Balance} рублей.";
            }
            else
            {
                return "Сумма пополнения должна быть больше нуля.";
            }

        }

        public string GetMoney(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return $"Со счета {AccountNumber} снято {amount} тенге. Новый баланс: {Balance} рублей.";
            }
            else
            {
                return "Сумма снятия должна быть больше нуля и меньше текущего баланса.";
            }

        }
    }
}
