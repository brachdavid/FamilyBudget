namespace FamilyBudget
{
    /// <summary>
    /// Třída Expense představuje výdaj a dědí z EntityBase.
    /// </summary>
    /// <remarks>
    /// Konstruktor pro vytvoření nové výdajové položky
    /// </remarks>
    /// <param name="itemName">Název výdajové položky</param>
    /// <param name="itemValue">Hodnota výdajové položky</param>
    public class Expense(string itemName, double itemValue) : EntityBase<Expense>, ITransaction
    {
        /// <summary>
        /// Název výdajové položky
        /// </summary>
        public string ItemName { get; private set; } = itemName;

        /// <summary>
        /// Hodnota výdajové položky
        /// </summary>
        public double ItemValue { get; private set; } = itemValue;

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
