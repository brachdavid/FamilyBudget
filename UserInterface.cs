using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    public class UserInterface
    {
        public Budget FamilyBudget { get; private set; }
        public UserInterface()
        {
            FamilyBudget = new Budget();
        }
        public void RunProgram()
        {
            char choice = '0';
            while (choice != '9')
            {
                PrintMenu();
                Console.Write("Your choice: ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                ProcessChoice(choice);
            }
            PrintMenu();
        }
        private void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------Family Budget------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Welcome to the Family Budget app. \nYou currently have {FamilyBudget.TotalBudget} Czech crowns. \nWhat would you like to do now?\n");
            Console.WriteLine("1 - Spend money.");
            Console.WriteLine("2 - Get money.");
            Console.WriteLine("3 - Print all expenses.");
            Console.WriteLine("4 - Print all incomes");
            Console.WriteLine("5 - Print all transactions.");
            Console.WriteLine("6 - Sort the expenses by value.");
            Console.WriteLine("7 - Sort the incomes by value.");
            Console.WriteLine("8 - How much money is in our family budget?");
            Console.WriteLine("9 - Exit the program.\n");
        }

        private void ProcessChoice(char choice)
        {
            switch (choice)
            {
                case '1':
                    SpendMoney();
                    break;
                case '2':
                    GetMoney();
                    break;
                case '3':
                    FamilyBudget.PrintExpenses();
                    break;
                case '4':
                    FamilyBudget.PrintIncomes();
                    break;
                case '5':
                    PrintAllTransactions();
                    break;
                case '6':
                    FamilyBudget.PrintSortedExpenses();
                    break;
                case '7':
                    FamilyBudget.PrintSortedIncomes();
                    break;
                case '8':
                    Console.WriteLine(FamilyBudget);
                    break;
                default:
                    Console.WriteLine("Invalid selection, press any key and try again.");
                    break;
            }
            PrintMessage();
            Console.ReadKey();
        }

        private void SpendMoney()
        {
            Console.WriteLine("What did you spend the money on?");
            string itemName = GetItemName();
            double itemValue = GetItemValue();
            FamilyBudget.AddExpense(itemName, itemValue);
        }

        private void GetMoney()
        {
            Console.WriteLine("What did you get the money for?");
            string itemName = GetItemName();
            double itemValue = GetItemValue();
            FamilyBudget.AddIncome(itemName, itemValue);
        }
        private string GetItemName()
        {
            Console.Write("Item name: ");
            return ReturnValidatedText();
        }

        private double GetItemValue()
        {
            Console.Write("Item value: ");
            return ReturnValidatedNumber();
        }

        private string ReturnValidatedText()
        {
            string userInput;
            while (string.IsNullOrWhiteSpace(userInput = Console.ReadLine()!.Trim()))
                Console.WriteLine("Item name cannot be empty. Please try again.");
            return userInput;
        }

        private double ReturnValidatedNumber()
        {
            double userInput;
            while (!double.TryParse(Console.ReadLine()!, out userInput) || userInput <= 0)
                Console.WriteLine("Item value must be a number (greater than zero). Please try again.");
            return userInput;
        }
        private void PrintAllTransactions()
        {
            Console.WriteLine("Incomes:");
            FamilyBudget.PrintIncomes();
            Console.WriteLine("\nExpenses:");
            FamilyBudget.PrintExpenses();
        }
        private void PrintMessage()
        {
            Console.WriteLine("\nPress any key to return to the main menu.");
        }
    }
}
