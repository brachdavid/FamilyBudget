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

        private List<Income> incomes;
        private List<Expense> expenses;

        public Budget() 
        {
            incomes = new List<Income>();
            expenses = new List<Expense>();
        }

        public void AddIncome(string itemName, double itemValue)
        {
            incomes.Add(new Income(itemName, itemValue));
            TotalBudget += itemValue;
        }

        public void AddExpense(string itemName, double itemValue)
        {
            expenses.Add(new Expense(itemName, itemValue));
            TotalBudget -= itemValue;
        }

        public void PrintIncomes()
        {
            foreach (Income income in incomes)
                Console.WriteLine(income);
        }
        public void PrintExpenses()
        {
            foreach(Expense expense in expenses)
                Console.WriteLine(expense);
        }

        public bool EmptyList()
        {
            return incomes.Count == 0 || expenses.Count == 0;
        }
    }
}
