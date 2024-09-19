using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    /// <summary>
    /// Třída Income představuje příjem a dědí z EntityBase.
    /// </summary>
    public class Income : EntityBase<Income>, ITransaction
    {
        /// <summary>
        /// Název příjmové položky
        /// </summary>
        public string ItemName { get; private set; }

        /// <summary>
        /// Hodnota příjmové položky
        /// </summary>
        public double ItemValue { get; private set; }

        /// <summary>
        /// Konstruktor pro vytvoření nové příjmové položky
        /// </summary>
        /// <param name="itemName">Název příjmové položky</param>
        /// <param name="itemValue">Hodnota příjmové položky</param>
        public Income(string itemName, double itemValue)
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
