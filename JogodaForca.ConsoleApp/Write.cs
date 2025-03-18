namespace JogodaForca.ConsoleApp
{
    class Write
    {
        public static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("      Bem-Vindo ao Jogo da Forca!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Iniciar um jogo");
            Console.WriteLine("2 - Como Jogar");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("----------------------------------------");
            Console.Write("-> Digite uma opção: ");
        }

        public static void Rules() 
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("                Regras");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Ao iniciar um jogo um palavra aleatória será gerada.");
            Console.WriteLine("2. Você só pode digitar 1 letra por vez ou não será aceito."); 
            Console.WriteLine("3. Você terá apenas 7 chances de errar a letra.");     
            Console.WriteLine("4. As palavras secretas que serão geradas são frutas desta lista: ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("ABACATE, ABACAXI, ACEROLA, ACAI, ARACA, BACABA, BACURI,\nBANANA, CAJA, CAJU, CARAMBOLA, CUPUACU, GRAVIOLA,\nGOIABA, JABUTICABA, JENIPAPO, MACA, MANGABA, MANGA,\nMARACUJA, MURICI, PEQUI, PITANGA, PITAYA, SAPOTI,\nTANGERINA, UMBU, UVA, UVAIA.");
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("-> Enter para voltar ao menu: ");
            Console.ReadKey();
        }

        public static void PlayerWin(string randomWord) 
        {

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("    *          *          *            ");
            Console.WriteLine("           *          *          *     ");
            Console.WriteLine("                                       ");
            Console.WriteLine("           !!! Parabéns !!!            ");
            Console.WriteLine("     Você acertou a palvra secreta!    ");
            Console.WriteLine($"          > {randomWord} <            ");
            Console.WriteLine("     *             *                   ");
            Console.WriteLine(" *          *          *              *");
            Console.WriteLine("---------------------------------------");           
        }
        public static void PlayerHanged(string RandomWord) 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Que pena! Você usou todas as tentativas.");
            Console.WriteLine($"A palavra secreta era: {RandomWord}.");
            Console.WriteLine("Boa Sorte na próxima!");
            Console.WriteLine("----------------------------------------");          
        }

        public static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine(" Até a próxima!  0/ ");
            Console.WriteLine("---------------------");
        }

        public static void WrongOption() 
        {
            Console.Write(" -> (X) Opção inválida! Digite novamente: ");

        }
        public static void NotaLetter() 
        {
            Console.Write(" -> (X) Você não digitou uma letra! Tente novamente: ");
        }
    }
}
