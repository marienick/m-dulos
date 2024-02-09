using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp233.Entities
{
    // A partir do momento que colocamos esse sealed não podemos criar subclasses dela.
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        // Método sobrescrito que utiliza a função Withdaw da superclasse e implementa esse método subtraindo  menos 2 
        // Utiliza a palavra sealed que faz com que esse método não seja sobreposto novamente em uma subclasse.
        public sealed override void Withdraw(double amoun)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}