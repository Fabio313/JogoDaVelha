using System;

namespace JogodaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P1win = 0, P2win = 0, velha = 0; 
            int opc;
            int numerogame = 0;
            string historico = "";
            JogoDaVelha nJogo = null;
            do
            {
                Console.ReadKey();
                Console.Clear();
                
                opc = menu();
                switch (opc)
                {
                    case 1:
                        string player = "X";
                        int play = 1, posicao;
                        nJogo = new JogoDaVelha();
                        Console.WriteLine("Player 1 = X\nPlayer 2 = O");
                        for (int i = 0; i < 9; i++)
                        {
                            do
                            {
                                Console.Clear();
                                nJogo.MostrarTabuleiro();
                                Console.WriteLine("Player {0}", play);
                                Console.Write("Digite a posição do seu [{0}]: ", player);
                                if (int.TryParse(Console.ReadLine(), out int CanParse))
                                    posicao = CanParse;
                                else
                                    posicao = -1;
                                if (nJogo.VerificaPosicao(posicao) == false)
                                {
                                    Console.WriteLine("Posição invalida digite novamente!");
                                    Console.ReadKey();
                                }
                            } while (nJogo.VerificaPosicao(posicao)==false);
                            play = nJogo.Adicionar(posicao, player, play);
                            if (nJogo.SituacaoJogo() != true)
                            {
                                if (play == 1)
                                {
                                    play = 2;
                                    player = "O";
                                }
                                else
                                {
                                    play = 1;
                                    player = "X";
                                }
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (nJogo.SituacaoJogo() == true)
                        {
                            Console.Clear();
                            Console.WriteLine("O player {0} venceu!", play);
                            nJogo.MostrarTabuleiro();
                            if (play == 1)
                                P1win++;
                            else
                                P2win++;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Deu velha");
                            nJogo.MostrarTabuleiro();
                            velha++;
                        }
                        numerogame++;
                        historico += "\nPartida" + numerogame + "\n";
                        for(int i = 0; i < 3; i++)
                        {
                            for(int j = 0; j < 3; j++)
                            {
                                if((nJogo.Tabuleiro[i,j]=="1") || (nJogo.Tabuleiro[i, j] == "2") || (nJogo.Tabuleiro[i, j] == "3") || (nJogo.Tabuleiro[i, j] == "4") || (nJogo.Tabuleiro[i, j] == "5") || (nJogo.Tabuleiro[i, j] == "6") || (nJogo.Tabuleiro[i, j] == "7") || (nJogo.Tabuleiro[i, j] == "8") || (nJogo.Tabuleiro[i, j] == "9"))
                                    historico += "[ ]";
                                else
                                    historico += "[" + nJogo.Tabuleiro[i,j] + "]";
                            }
                            historico += "\n";
                        }
                        
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(">>>>PLACAR<<<<");
                        Console.WriteLine("Player 1: {0}",P1win);
                        Console.WriteLine("Player 2: {0}", P2win);
                        Console.WriteLine("Velha: {0}", velha);
                        break;
                    case 3:
                        Console.WriteLine(">>>>HISTORICO<<<<");
                        Console.WriteLine(historico);
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Adeus ;-;");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Invalida!\nDigite novamente.");
                        break;
                }
            }while(opc != 0);
        }

        static int menu()
        {
            int opc;
            Console.WriteLine("=========JOGO DA VELHA=========");
            Console.WriteLine("1-Novo Jogo\n2-Placar\n3-Historico\n0-Sair");
            Console.Write("Opção: ");
            if(int.TryParse(Console.ReadLine(),out int CanParse))
            {
                opc = CanParse;
            }
            else{
                opc = -1;
            }
            return opc;
        }
    }
}
