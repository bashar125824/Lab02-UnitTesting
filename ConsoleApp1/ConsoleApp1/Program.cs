using System;

namespace ConsoleApp1
{
    class Program
    {
        static public decimal Balance = 100;

        
        static public decimal ReadLines(){

            Console.WriteLine(" Please Enter Withdraw / Deposite value ");
            decimal value = Convert.ToInt32(Console.ReadLine());

            return value; 
                
        }


        static public decimal ViewBalance()
        {

            return Balance;
        }

        static public decimal Withdraw()
        {
            
            
                decimal withDrawValue = ReadLines();
            try { }
            catch (IndexOutOfRangeException e)
            {
                if (withDrawValue > Balance)
                {

                    throw new IndexOutOfRangeException("Withdraw Value is bigger than Balance , Please Enter a correct value !", e);
                }


                if (withDrawValue < 0)
                {

                    throw new IndexOutOfRangeException("Withdraw Value is less than ZERO , Please Enter a correct value !", e);
                }
            }
            
            return Balance - withDrawValue;
        }

        static public decimal Deposit()
        {

            decimal depositValue = ReadLines();
            try { }
            catch (IndexOutOfRangeException e) {
                if (depositValue < 0)
                {
                    throw new IndexOutOfRangeException("Deposit Value is less than ZERO , Please Enter a correct value !", e);
                }
            }


            return Balance + depositValue;
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

                    Console.WriteLine("Your Balance after Withdraw : " + Withdraw());

                    Console.WriteLine(" ************************************************* ");


                    Console.WriteLine("  Please choose a number :  ");
                }
                else if (choice == 3)
                {

                    Console.WriteLine("Your Balance before Deposit : " + ViewBalance());

                    Console.WriteLine(" ------------------------------------------------- ");

                    Console.WriteLine("Your Balance after Deposit : " + Deposit());

                    Console.WriteLine(" ************************************************* ");

                    Console.WriteLine("  Please choose a number :  ");

                   
                }
                else if (choice == 4)
                {
                    Console.WriteLine(" Exit out of Program ! ");
                }

            }
            
        }


        static void Main(string[] args)
        {
            UserInterface();
        }



    } 
    
}
