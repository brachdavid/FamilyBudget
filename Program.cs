namespace FamilyBudget
{
    // Třída Program slouží jako vstupní bod aplikace a spouští uživatelské rozhraní.
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření nové instance uživatelského rozhraní
            UserInterface userInterface = new UserInterface();

            // Spuštění programu na instanci uživatelského rozhraní
            userInterface.RunProgram();
        }
    }
}
