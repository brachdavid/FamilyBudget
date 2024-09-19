using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    /// <summary>
    /// Třída Expense představuje výdaj a dědí z EntityBase.
    /// </summary>
    public class Expense : EntityBase<Expense>, ITransaction
    {
        /// <summary>
        /// Název výdajové položky
        /// </summary>
        public string ItemName { get; private set; }

        /// <summary>
        /// Hodnota výdajové položky
        /// </summary>
        public double ItemValue { get; private set; }

        /// <summary>
        /// Konstruktor pro vytvoření nové výdajové položky
        /// </summary>
        /// <param name="itemName">Název výdajové položky</param>
        /// <param name="itemValue">Hodnota výdajové položky</param>
        public Expense(string itemName, double itemValue) 
        {
            ItemName = itemName;
            ItemValue = itemValue;
        }

        /// <summary>
        /// Metoda vypíše ID, název a hodnotu výdajové položky
        /// </summary>
        /// <returns>ID, Název položky, Hodnota položky</returns>
        public override string ToString()
        {
            return $"Id: {Id}\t\tItem name: {ItemName}\t\tItem value: {ItemValue} Kč";
        }
    }
}
