using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing MPSA Bank");
            IBank mpsa = BankFactory.GetBankObject("MPSA");
            mpsa.ValidateCard();
            mpsa.WithdrawMoney();
            mpsa.CheckBalanace();
            mpsa.BankTransfer();
            mpsa.MiniStatement();
            Console.WriteLine("\nTransaction doing Vodacom mobile Bank");
            IBank VODACOM = BankFactory.GetBankObject("VODACOM");
            VODACOM.ValidateCard();
            VODACOM.WithdrawMoney();
            VODACOM.CheckBalanace();
            VODACOM.BankTransfer();
            VODACOM.MiniStatement();
            Console.Read();
        }
    }
    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }
    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "MPSA")
            {
                BankObject = new MPSA();
            }
            else if (bankType == "VODACOM")
            {
                BankObject = new VODACOM();
            }
            return BankObject;
        }
    }
    public class MPSA : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("MPSA Bank Bank Transfer");
        }
        public void CheckBalanace()
        {
            Console.WriteLine("MPSA Bank Check Balanace");
        }
        public void MiniStatement()
        {
            Console.WriteLine("MPSA Bank Mini Statement");
        }
        public void ValidateCard()
        {
            Console.WriteLine("MPSA Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("MPSA Bank Withdraw Money");
        }
    }
    public class VODACOM : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("VODACOM Mobile  Bank Transfer");
        }
        public void CheckBalanace()
        {
            Console.WriteLine("VODACOM Mobile Bank Check Balanace");
        }
        public void MiniStatement()
        {
            Console.WriteLine("VODACOM Mobile Bank Mini Statement");
        }
        public void ValidateCard()
        {
            Console.WriteLine("VODACOM Mobile Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("VODACOM Mobile Bank Withdraw Money");
        }
    }
}