namespace FamilyBudget
{
    // Třída Program slouží jako vstupní bod aplikace a spouští uživatelské rozhraní.
    class Program
    {
        static void Main()
        {
            // Vytvoření nové instance uživatelského rozhraní
            UserInterface userInterface = new();

            // Spuštění programu na instanci uživatelského rozhraní
            userInterface.RunProgram();
        }
    }
}
