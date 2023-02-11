using System;
namespace EncapsulationDemo
{
    public class Compte
    {
        //Hiding class data by declaring the variable as private
        private double balance;
        //Creating public Setter and Getter methods
        //Public Getter Method
        //This method is used to return the data stored in the balance variable
        public double GetBalance()
        {
            //add validation logic if needed
            return balance;
        }
        //Public Setter Method
        //This method is used to stored the data  in the balance variable
        public void SetBalance(double balance)
        {
            // add validation logic to check whether data is correct or not
            this.balance = balance;
        }
    }
    class Program
    {
        public static void Main()
        {
            Compte mpsa = new Compte();
            //You cannot access the Private Variable
            //bank.balance; //Compile Time Error
            //You can access the private variable via public setter and getter methods
            mpsa.SetBalance(500);
            Console.WriteLine(mpsa.GetBalance());
            Console.ReadKey();
        }
    }
}