using LearningMathGame;

class Program
{

    public static void Main()
    {
        Helpers helpers = new Helpers();

        string name = Helpers.GetName();

        Menu menu = new Menu();

        GameEngine engine = new GameEngine();

        bool isRunning = true;

        while (isRunning)
        {
            DateTime date = DateTime.Now;
            string gameChoice = menu.ShowMenu(name, date);

            switch (gameChoice)
            {
                case "1":
                    GameEngine.PlayAddition("Addition Selected.");
                    break;
                case "2":
                    GameEngine.PlaySubtraction("Subtraction Selected.");
                    break;
                case "3":
                    GameEngine.PlayMultiplication("Multiplication Selected.");
                    break;
                case "4":
                    GameEngine.PlayDivision("Division Selected.");
                    break;
                case "5":
                    isRunning = false;
                    GameEngine.QuitProgram();
                    break;
                case "6":
                    helpers.Getgames();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}