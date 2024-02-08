using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp233.Entities
{
     class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance,double interestRate): base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        // Método sobrescrito
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}