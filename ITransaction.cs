namespace FamilyBudget
{
    /// <summary>
    /// Rozhraní ITransaction definuje základní vlastnosti transakce, jako jsou název položky, její hodnota a ID.
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// ID provedené transakce
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Název provedené transakce
        /// </summary>
        string ItemName { get; }

        /// <summary>
        /// Hodnota provedené transakce
        /// </summary>
        double ItemValue { get; }
    }
}
