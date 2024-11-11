namespace FamilyBudget
{
    /// <summary>
    /// Třída Income představuje příjem a dědí z EntityBase.
    /// </summary>
    /// <remarks>
    /// Konstruktor pro vytvoření nové příjmové položky
    /// </remarks>
    /// <param name="itemName">Název příjmové položky</param>
    /// <param name="itemValue">Hodnota příjmové položky</param>
    public class Income(string itemName, double itemValue) : EntityBase<Income>, ITransaction
    {
        /// <summary>
        /// Název příjmové položky
        /// </summary>
        public string ItemName { get; private set; } = itemName;

        /// <summary>
        /// Hodnota příjmové položky
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
