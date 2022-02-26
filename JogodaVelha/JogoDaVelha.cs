using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodaVelha
{
    internal class JogoDaVelha
    {
        public string[,] Tabuleiro { get; set; }

        public JogoDaVelha()
        {
            int posicao = 0;
            string position;
            Tabuleiro = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    posicao++;
                    position = ""+posicao;
                    Tabuleiro[i, j] = position;
                }
            }
        }

        public void MostrarTabuleiro()
        {
            for(int i =0; i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    Console.Write("[{0}]",Tabuleiro[i,j]);
                }
                Console.WriteLine();
            }
        }

        public bool SituacaoJogo()
        {
            bool acabou = false;
            if ((Tabuleiro[0,0] == Tabuleiro[1,1])&&(Tabuleiro[1, 1] == Tabuleiro[2,2]))
                acabou = true;
            if ((Tabuleiro[0, 2] == Tabuleiro[1, 1]) && (Tabuleiro[1, 1] == Tabuleiro[2, 0]))
                acabou = true;
            for(int i = 0;i<3;i++)
            {
                if((Tabuleiro[i, 0] == Tabuleiro[i, 1]) && (Tabuleiro[i, 1] == Tabuleiro[i, 2]))
                    acabou = true;
                if ((Tabuleiro[0, i] == Tabuleiro[1, i]) && (Tabuleiro[1, i] == Tabuleiro[2, i]))
                    acabou = true;
            }
            return acabou;
        }

        public int Adicionar(int opc, string player, int play)
        {
            switch(opc)
            {
                case 1:
                    if (Tabuleiro[0, 0] == "1")
                        Tabuleiro[0, 0] = player;
                    break;
                case 2:
                    if (Tabuleiro[0, 1] == "2")
                        Tabuleiro[0, 1] = player;
                    break;
                case 3:
                    if (Tabuleiro[0, 2] == "3")
                        Tabuleiro[0, 2] = player;
                    break;
                case 4:
                    if (Tabuleiro[1, 0] == "4")
                        Tabuleiro[1, 0] = player;
                    break;
                case 5:
                    if (Tabuleiro[1, 1] == "5")
                        Tabuleiro[1, 1] = player;
                    break;
                case 6:
                    if (Tabuleiro[1, 2] == "6")
                        Tabuleiro[1, 2] = player;
                    break;
                case 7:
                    if (Tabuleiro[2, 0] == "7")
                        Tabuleiro[2, 0] = player;
                    break;
                case 8:
                    if (Tabuleiro[2, 1] == "8")
                        Tabuleiro[2, 1] = player;
                    break;
                case 9:
                    if (Tabuleiro[2, 2] == "9")
                        Tabuleiro[2, 2] = player;
                    break;
                default:
                    break;
            }
            return play;
        }

        public bool VerificaPosicao(int posicao)
        {
            bool tablz = false;
            switch (posicao)
            {
                case 1:
                    if (Tabuleiro[0, 0] == "1")
                        tablz = true;
                    break;
                case 2:
                    if (Tabuleiro[0, 1] == "2")
                        tablz = true;
                    break;
                case 3:
                    if (Tabuleiro[0, 2] == "3")
                        tablz = true;
                    break;
                case 4:
                    if (Tabuleiro[1, 0] == "4")
                        tablz = true;
                    break;
                case 5:
                    if (Tabuleiro[1, 1] == "5")
                        tablz = true;
                    break;
                case 6:
                    if (Tabuleiro[1, 2] == "6")
                        tablz = true;
                    break;
                case 7:
                    if (Tabuleiro[2, 0] == "7")
                        tablz = true;
                    break;
                case 8:
                    if (Tabuleiro[2, 1] == "8")
                        tablz = true;
                    break;
                case 9:
                    if (Tabuleiro[2, 2] == "9")
                        tablz = true;
                    break;
                default:
                    tablz = false;
                    break;
            }
            return tablz;
        }
    }
}
