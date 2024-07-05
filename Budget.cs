using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    public class Budget
    {
        public double TotalBudget { get; private set; } = 100000;

        public List<Income> Incomes { get; private set; }
        public List<Expense> Expenses { get; private set; }

        public Budget() 
        {
            Incomes = new List<Income>();
            Expenses = new List<Expense>();
        }

        public void AddIncome(string itemName, double itemValue)
        {
            Incomes.Add(new Income(itemName, itemValue));
            TotalBudget += itemValue;
        }

        public void AddExpense(string itemName, double itemValue)
        {
            Expenses.Add(new Expense(itemName, itemValue));
            TotalBudget -= itemValue;
        }

        public void PrintIncomes()
        {
            if (Incomes.Count == 0)
                Console.WriteLine("No incomes recorded.");
            else
                foreach (Income income in Incomes)
                    Console.WriteLine(income);
        }
        public void PrintExpenses()
        {
            if (Expenses.Count == 0)
                Console.WriteLine("No expenses recorded.");
            else
                foreach (Expense expense in Expenses)
                    Console.WriteLine(expense);
        }

        public void PrintSortedExpenses()
        {
            var query = from expense in Expenses
                        orderby expense.ItemValue
                        select expense;

            if (Expenses.Count == 0)
                Console.WriteLine("No expenses recorded.");
            else
                foreach (Expense expense in query)
                    Console.WriteLine(expense);
        }
        public void PrintSortedIncomes()
        {
            var query = from income in Incomes
                        orderby income.ItemValue
                        select income;

            if (Incomes.Count == 0)
                Console.WriteLine("No expenses recorded.");
            else
                foreach (Income income in query)
                    Console.WriteLine(income);
        }

        public override string ToString()
        {
            return $"We have {TotalBudget} Czech crowns in our family budget just now.";
        }
    }
}
