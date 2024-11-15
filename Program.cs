using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {

        static double CalculateAverage(int[] marks)
        {
            int sum = 0;

            foreach (int mark in marks)
            {
                sum += mark;
            }

            return (double)sum / marks.Length;
        }

        static char DetermineGrade(double average)
        {
            if (average >= 90)
            {
                return 'A';
            }
            else if (average >= 80)
            {
                return 'B';
            }
            else if (average >= 70)
            {
                return 'C';
            }
            else if (average >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            int[] marks = new int[5];
            double average;

            try
            {
                Console.WriteLine("Enter marks for five subjects:");

                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write($"Subject {i + 1}: ");
                    marks[i] = int.Parse(Console.ReadLine());

                    if (marks[i] < 0 || marks[i] > 100)
                    {
                        throw new ArgumentOutOfRangeException("Marks must be between 0 and 100.");
                    }
                }

                average = CalculateAverage(marks);
                char grade = DetermineGrade(average);

                Console.WriteLine($"Average marks: {average:F2}");
                Console.WriteLine($"Grade: {grade}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
        }



        class BankAccount
        {
            private string _accountHolder;
            private decimal _balance;

            public BankAccount(string accountHolder, decimal initialBalance)
            {
                _accountHolder = accountHolder;
                _balance = initialBalance;
            }

            public string AccountHolder
            {
                get { return _accountHolder; }
                set { _accountHolder = value; }
            }

            public decimal Balance
            {
                get { return _balance; }
            }

            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }

                _balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }

                if (amount > _balance)
                {
                    throw new InsufficientFundsException("Insufficient funds for withdrawal.");
                }

                _balance -= amount;
            }

            public class InsufficientFundsException : Exception
            {
                public InsufficientFundsException(string message) : base(message)
                {
                }
            }
        

                 

        }
    }
}