using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp233.Entities
{
    class Account
    {
        public int Number { get; protected  set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        // Método da superclasse que vai ser sobrescrito na subclasse utiliza o prefixo "virtual"
        public virtual void Widthdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
