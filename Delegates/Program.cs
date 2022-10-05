using System;
namespace delegates
{
    public delegate void BankName(string bankName, string interest);
    public class Bank
    {
        public static void Interest(string bankName, string interest)
         {
            Console.WriteLine($"Your Bank name is :{bankName} and Rate of interest is : {interest} ");
        }
    }

    internal class delegates
    {
        public static void Main()
        {
            Console.WriteLine("BankList : sbi bank , icici bank , axis bank , hdfc bank and kotak mahindra bank");
            Console.WriteLine("Enter your bank name from above list : ");
            string name = Console.ReadLine().ToUpper();
            if (name == "SBI BANK" || name == "SBI")
                Bank.Interest("SBI", "2.70%");
            else if (name == "HDFC BANK" || name == "HDFC")
                Bank.Interest("HDFC Bank", "3.00 % – 3.50 %");
            else if (name == "KOTAK MAHINDRA BANK" || name == "KOTAK MAHINDRA")
                Bank.Interest("Kotak Mahindra Bank", "3.50%");
            else if (name == "AXIS BANK" || name == "AXIS")
                Bank.Interest("Axis Bank", "3.00% – 3.50%");
            else if (name == "ICICI BANK" || name == "ICICI")
                Bank.Interest("ICICI Bank", "3.00% – 3.50%");
            else
                Console.WriteLine("NOT FOUND BANK DETAILS");
        }
                       
    }
}