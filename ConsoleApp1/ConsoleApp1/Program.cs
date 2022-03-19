using System;

namespace ConsoleApp1
{
    class Program
    {
        static public decimal Balance = 100;

        static public decimal ViewBalance()
        {

            return Balance;
        }

        static public decimal Withdraw(decimal withdrawValue)
        {

            if ( withdrawValue > Balance)
            {

                throw new ArgumentOutOfRangeException();
            }

            if (withdrawValue < 0)
            {

                throw new ArgumentOutOfRangeException();
            }
            return Balance - withdrawValue;
        }

        static public decimal Deposit(decimal DepositValue)
        {
            if (DepositValue < 0)
            {
                throw new ArgumentOutOfRangeException();
            }


            return Balance + DepositValue;
        }

        public static void UserInterface()
        {

            Console.WriteLine("-----Welcome to ATM System----- ");
            Console.WriteLine("-----Our Services----- ");
            Console.WriteLine("  Please choose a number :  ");
            int choice = 0; 
            while (choice != 4)
            {
                Console.WriteLine(" 1. View Balance");
                Console.WriteLine(" 2. Withdraw Money");
                Console.WriteLine(" 3. Deposite Money");
                Console.WriteLine(" 4. Exit");

                Console.WriteLine("******************************");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Your Balance : "+ ViewBalance());

                    Console.WriteLine(" ************************************************* ");


                    Console.WriteLine("  Please choose a number :  ");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Your Balance before Withdraw : " + ViewBalance());

                    Console.WriteLine(" ------------------------------------------------- ");

                    Console.WriteLine("Your Balance after Withdraw : " + Withdraw(10));

                    Console.WriteLine(" ************************************************* ");


                    Console.WriteLine("  Please choose a number :  ");
                }
                else if (choice == 3)
                {

                    Console.WriteLine("Your Balance before Deposit : " + ViewBalance());

                    Console.WriteLine(" ------------------------------------------------- ");

                    Console.WriteLine("Your Balance after Deposit : " + Deposit(10));

                    Console.WriteLine(" ************************************************* ");

                    Console.WriteLine("  Please choose a number :  ");
                }

            }
            
        }


        static void Main(string[] args)
        {
            UserInterface();
        }



    } 
    
}
