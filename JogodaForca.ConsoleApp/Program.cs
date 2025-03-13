namespace JogodaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            while (true)
            {
                string[] words =
                {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
                };

                int chosenindex = random.Next(words.Length);
                string randomWord = words[chosenindex];

                char[] findLetters = new char[randomWord.Length];

                for (int character = 0; character < findLetters.Length; character++)
                {
                    findLetters[character] = '_';
                }

                int errorsQuantity = 0;
                bool playerWin = false;
                bool playerhanged = false;

                do
                {
                    string head = errorsQuantity >= 1 ? " O " : " ";
                    string body = errorsQuantity >= 2 ? "x" : " ";
                    string body2 = errorsQuantity >= 2 ? "x" : " ";
                    string leftArm = errorsQuantity >= 3 ? "/" : " ";
                    string rightArm = errorsQuantity >= 4 ? @"\" : " ";
                    string leftLeg = errorsQuantity >= 5 ? "/ " : " ";
                    string rightLeg = errorsQuantity >= 5 ? "\\" : " ";

                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine(" ___________         ");
                    Console.WriteLine(" |/        |         ");
                    Console.WriteLine(" |        {0}        ", head);
                    Console.WriteLine(" |        {0}{1}{2}  ", leftArm, body, rightArm);
                    Console.WriteLine(" |         {0}       ", body2);
                    Console.WriteLine(" |        {0}{1}     ", leftLeg, rightLeg);
                    Console.WriteLine(" |                   ");
                    Console.WriteLine(" |                   ");
                    Console.WriteLine("_|____               ");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Erros do jogador: " + errorsQuantity);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"Palavra escolhida: {String.Join("", findLetters)}");
                    Console.WriteLine("----------------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char shot = Console.ReadLine()!.ToUpper()[0];
                    bool letterFound = false;

                    for (int counter = 0; counter < randomWord.Length; counter++)
                    {
                        char actualChar = randomWord[counter];
                        if (shot == actualChar)
                        {
                            findLetters[counter] = actualChar;
                            letterFound = true;
                        }
                    }

                    if (letterFound == false)
                    {
                        errorsQuantity++;
                    }

                    string wordFound = string.Join("", findLetters);
                    playerWin = wordFound == randomWord;
                    playerhanged = errorsQuantity > 5;

                    if (playerWin)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"Você acertou a palavra secreta {randomWord}, parabéns!");
                        Console.WriteLine("----------------------------------------------");
                        break;
                    }
                    else if (playerhanged)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Você errou! Tente novamente!");
                        Console.WriteLine("----------------------------------------------");
                        break;
                    }



                } while (playerhanged == false && playerWin == false);              
                Console.Write("Deseja jogar novamente? (S/N)");
                string option = Console.ReadLine()!.ToUpper();
                if (option != "S")
                {
                    break;
                }  
            }
        }
    }
}
       
    

