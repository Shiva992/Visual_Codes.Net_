using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_exception_handling
{
    class Account
    {
        public Account(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }
        public string Name { get; private set; }
        public int Balance { get; private set; }

        public void Debit(int amount)
        {
            if (Balance < 600) throw new Exception(Name, Balance, amount);
            Balance = Balance - amount;
        }

        public void Credit(int amount) => Balance = amount + Balance;
    }
}