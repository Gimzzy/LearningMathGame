 namespace LearningMathGame
{
    internal class Menu
    {
        GameEngine engine = new();
        internal string ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            string separation = "----------------------------------";
            Console.WriteLine(separation);
            Console.WriteLine($"Hello {name}! Today's date is: {date}\n");
            Console.WriteLine(@"What game would you like to play today? Choose from the options below:
1 - Addition 5 Questions
2 - Subtraction 5 Questions
3 - Multiplication 5 Questions
4 - Division 5 Questions
5 - Quit The Program
6 - View Game History");
            Console.WriteLine(separation);

            return Console.ReadLine()?.Trim();
        }
    }
}





