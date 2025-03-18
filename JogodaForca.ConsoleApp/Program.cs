namespace JogodaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Write.Menu();
                int menuOption = Validator.IsaOption(1, 3);
                switch (menuOption)
                {
                    case 1: HangmanGame.StartGame(); break;
                    case 2: Write.Rules(); break;
                    case 3: Write.Goodbye(); return;
                }
            }
        }
    }
}




