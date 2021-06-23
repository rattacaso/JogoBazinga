using System;


namespace PedraTesouraPapel
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, namePlayer, inputCPU;
        
            int randomInt;
            
            
            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                Console.WriteLine("Player name: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                namePlayer = Console.ReadLine();

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{namePlayer} escolha entre: PEDRA, PAPEL, TESOURA, LAGARTO e SPOCK: (Ganha quem vencer 3 rodadas)   ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 5);
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "PEDRA";
                            Console.WriteLine("Computador escolheu PEDRA");
                            if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("EMPATE!!\n\n");
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                 Console.ForegroundColor = ConsoleColor.Green;
                                 Console.WriteLine($"PAPEL EMBRULHA PEDRA! {namePlayer} VENCEU!");
                                 scorePlayer++;
                            }
                            else if (inputPlayer == "TESOURA")
                            {   
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("PEDRA QUEBRA TESOURA! CPU VENCEU!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "LAGARTO")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("PEDRA esmaga LAGARTO! CPU VENCEU!");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"SPOCK VAPORIZA PEDRA! {namePlayer} VENCEU!");
                                scorePlayer++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPEL";
                            Console.WriteLine("Computador escolhe PAPEL");
                            if (inputPlayer == "PAPEL")
                            {   Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("EMPATE!!\n\n");
                            }
                            else if (inputPlayer == "PEDRA")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("PEDRA QUEBRA TESOURA, CPU VENCEU!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "TESOURA")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"TESOURA CORTA PAPEL {namePlayer} VENCEU!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "LAGARTO")
                            {
                                Console.WriteLine("LAGARTO COME PAPEL! JOGADOR VENCE!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"SPOCK FAZ UM ORIGAMI! {namePlayer} VENCEU!");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "TESOURA";
                            Console.WriteLine("Computador escolheu TESOURA");
                            if (inputPlayer == "TESOURA")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("EMPATE!!\n\n");
                            }
                            else if (inputPlayer == "PEDRA")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"PEDRA QUEBRA TESOURA, {namePlayer} VENCEU!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("TESOURA CORTA PAPEL, CPU VENCEU!!\n\n");
                                scoreCPU++;
                            }
                             else if (inputPlayer == "LAGARTO")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("TESOURA DECÁPITA LAGARTO! CPU VENCEU!");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {   
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"SPOCK ENTORTA TESOURA! {namePlayer} VENCEU!");
                                scorePlayer++;
                            }
                            break;
                        case 4:
                            inputCPU = "LAGARTO";
                            Console.WriteLine("Computador escolheu LAGARTO");
                            if (inputPlayer == "LAGARTO")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("EMPATE!!\n\n");
                            }
                            else if (inputPlayer == "PEDRA")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"PEDRA ESMAGA LAGARTO! {namePlayer}  VENCEU!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("LAGARTO COME PAPEL! CPU VENCEU!!\n\n");
                                scoreCPU++;
                            }
                             else if (inputPlayer == "TESOURA")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"TESOURA DECÁPITA LAGARTO! {namePlayer} VENCEU!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("LAGARTO ENVENENA SPOCK! CPU VENCEU!");
                                scoreCPU++;
                            }
                            break;
                        case 5:
                            inputCPU = "SPOCK";
                            Console.WriteLine("Computador escolheu SPOCK");
                            if (inputPlayer == "SPOCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("EMPATE!!\n\n");
                            }
                            else if (inputPlayer == "PEDRA")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("SPOCK VAPORIZA PEDRA! CPU VENCEU!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("SPOCK FAZ ORIGAMI! CPU VENCEU!!\n\n");
                                scoreCPU++;
                            }
                             else if (inputPlayer == "TESOURA")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("SPOCK ENTORTA TESOURA! CPU VENCEU!");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "LAGARTO")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"LAGARTO ENVENENA SPOCK! {namePlayer} VENCEU!");
                                scoreCPU++;
                            }
                            break;    

                        default:
                            
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("OPÇÃO INVÁLIDA!!");
                            break;
                    }

                    Console.WriteLine($"\n\nPLACAR:\tPLAYER:\t{scorePlayer}\tCPU:\t{scoreCPU}");

                }

                if (scorePlayer == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{namePlayer} VENCEU!");
                }
                else if (scoreCPU == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPU VENCEU!");
                }
                else
                {

                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Aceita novo desafio?(s/n)");
                string loop = Console.ReadLine();
                if (loop == "s")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                { 
                
                }

            }
        }
    }
}