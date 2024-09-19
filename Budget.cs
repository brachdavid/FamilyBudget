using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    /// <summary>
    /// Třída Budget obsahující logiku pro správu příjmů a výdajů
    /// </summary>
    public class Budget
    {
        /// <summary>
        /// Aktuální stav rodinné pokladny, počáteční hodnota je nastavena na 100 000 Kč
        /// </summary>
        public double TotalBudget { get; private set; } = 100000;

        /// <summary>
        /// Seznam rodinných příjmů
        /// </summary>
        public List<Income> Incomes { get; private set; }

        /// <summary>
        /// Seznam rodinných výdajů
        /// </summary>
        public List<Expense> Expenses { get; private set; }

        /// <summary>
        /// Konstruktor rozpočtu inicializující prázdné seznamy příjmů a výdajů
        /// </summary>
        public Budget() 
        {
            Incomes = new List<Income>();
            Expenses = new List<Expense>();
        }

        /// <summary>
        /// Metoda zaznamenává nový přírůstek do seznamu příjmů a mění průběžný stav rodinné pokladny
        /// </summary>
        /// <param name="itemName">Název příjmové položky</param>
        /// <param name="itemValue">Hodnota příjmové položky</param>
        public void AddIncome(string itemName, double itemValue)
        {
            Incomes.Add(new Income(itemName, itemValue));
            TotalBudget += itemValue;
        }

        /// <summary>
        /// Metoda zaznamenává nový přírůstek do seznamu výdajů a mění průběžný stav rodinné pokladny
        /// </summary>
        /// <param name="itemName">Název výdajové položky</param>
        /// <param name="itemValue">Hodnota výdajové položky</param>
        public void AddExpense(string itemName, double itemValue)
        {
            Expenses.Add(new Expense(itemName, itemValue));
            TotalBudget -= itemValue;
        }

        /// <summary>
        /// Metoda vypíše seznam zaznamenaných příjmů
        /// </summary>
        public void PrintIncomes()
        {
            if (Incomes.Count == 0)
                Console.WriteLine("No incomes recorded.");
            else
                foreach (Income income in Incomes)
                    Console.WriteLine(income);
        }

        /// <summary>
        /// Metoda vypíše seznam zaznamenaných výdajů
        /// </summary>
        public void PrintExpenses()
        {
            if (Expenses.Count == 0)
                Console.WriteLine("No expenses recorded.");
            else
                foreach (Expense expense in Expenses)
                    Console.WriteLine(expense);
        }

        /// <summary>
        /// Metoda vypíše seznam zaznamenaných výdajů seřazených podle hodnoty
        /// </summary>
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

        /// <summary>
        /// Metoda vypíše seznam zaznamenaných příjmů seřazených podle hodnoty
        /// </summary>
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

        /// <summary>
        /// Metoda vypíše aktuální stav rodinné pokladny
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"We have {TotalBudget} Czech crowns in our family budget just now.";
        }
    }
}
