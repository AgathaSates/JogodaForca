namespace JogodaForca.ConsoleApp
{
    class Validator
    {
        public static int IsaOption(int min, int max)
        {
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < min || option > max)
            {
                Write.WrongOption();
            }
            return option;
        }

        public static char IsaChar()
        {
            char letter;
            while (!char.TryParse(Console.ReadLine(), out letter) || !char.IsLetter(letter))
            {
                Write.NotaLetter();
            }
            return char.ToUpper(letter);
        }

        public static string YesorNo(string option)
        {
            while (string.IsNullOrWhiteSpace(option) || option.ToUpper() != "S" && option.ToUpper() != "N")
            {
                Write.WrongOption(); 
                option = Console.ReadLine()!;
            }
            return option.ToUpper();
        }
    }
}
