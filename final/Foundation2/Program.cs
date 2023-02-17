using System;
namespace EncapsulationDemo
{
    public class account
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
            account mpsa = new account();
           
            mpsa.SetBalance(500);
            Console.WriteLine(mpsa.GetBalance());
            Console.ReadKey();
        }
    }
}