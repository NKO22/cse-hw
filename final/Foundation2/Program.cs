using System;
namespace EncapsulationDemo
{
    public class Compte
    {
    
        private double balance;
        
        public double GetBalance()
        {
           
            return balance;
        }
        
        public void SetBalance(double balance)
        {
           
            this.balance = balance;
        }
    }
    class Program
    {
        public static void Main()
        {
            Compte mpsa = new Compte();
           
            mpsa.SetBalance(500);
            Console.WriteLine(mpsa.GetBalance());
            Console.ReadKey();
        }
    }
}