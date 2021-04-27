using System;

namespace TicTacTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] RC=new string[3,3];
            bool flag = false;
            int cont1=1;
            while(cont1!=10)
            {
                player1:
                Console.WriteLine("player 1 enter ur row and col");
                string b = Console.ReadLine();
                int R = RandC(b,"r");
                int C = RandC(b, "c");
                if(RC[R,C]!="x"&&RC[R,C]!="o")
                {
                    RC[R, C] = "x";
                    cont1++;
                }//To Check Whether the index is Filled or not
                else
                {
                    Console.WriteLine("the space is occupied");
                    goto player1;
                }
                flag = Check(R, C, RC, "player one");
                GameScene(RC);
                if (cont1==10)
                {
                    Console.WriteLine("out of moves");
                    break;
                }//To Check The Moves are over or not
                if(flag==true)
                {
                    break;
                }

                player2:
                Console.WriteLine("player 2 enter ur row and col");
                string b1 = Console.ReadLine();
                int R1 = RandC(b1, "r");
                int C1 = RandC(b1, "c");
                if (RC[R1, C1] != "x" && RC[R1, C1] != "o")
                {
                    RC[R1, C1] = "o";
                    cont1++;
                }
                else
                {
                    Console.WriteLine("the space is occupied");
                    goto player2;
                }
                flag = Check(R1, C1, RC, "player two");
                GameScene(RC);
                if (cont1 == 10)
                {
                    Console.WriteLine("out of moves");
                    break;
                }
               
                if (flag == true)
                {
                    break;
                }

                /* EndGame:
                 Console.WriteLine("End Game Scene");
                 for(int i=0;i<3;i++)
                 {
                     for(int j=0;j<3;j++)
                     {
                         if (RC[i, j] != "x" && RC[i, j] != "o")
                         {
                             Console.Write("-");
                         }
                         else
                         {
                             Console.Write(RC[i, j]);
                         }
                     }
                     Console.WriteLine();
                 }*/
            }
            
       
        }
        static void GameScene(string[,] RC)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (RC[i, j] != "x" && RC[i, j] != "o")
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" "+RC[i, j]+" ");
                    }
                    if(j!=2)
                        Console.Write("|");
                }
                Console.WriteLine();
                if (i != 2)
                    Console.WriteLine("___________");
                Console.WriteLine();
            }
        }
        static bool Check(int R, int C, string[,] RC, string player)
        {
            int cont2 = 0;
            string s;
            if (player == "player one")
                s = "x";
            else
                s = "o";
            for (int i = 0; i < 3; i++)//To Check The whether the row is filled or not
            {
                if (RC[R, i] == s)
                {
                    cont2++;
                }
                else
                {
                    break;
                }
                if (cont2 == 3)
                {
                    Console.WriteLine(player + " wins");
                    goto EndGame;
                }
            }
            cont2 = 0;
            for (int i = 0; i < 3; i++)//To Check The whether the Col is filled or not
            {

                if (RC[i, C] == s)
                {
                    cont2++;
                }
                if (cont2 == 3)
                {
                    Console.WriteLine(player + " wins");
                    goto EndGame;
                }
            }
            cont2 = 0;
            if (R == C)//To Check The Diagonally
            {
                for (int i = 0; i < 3; i++)
                {
                    if (RC[i, i] == s)
                    {
                        cont2++;
                    }
                    else
                    {
                        break;
                    }
                    if (cont2 == 3)
                    {
                        Console.WriteLine(player + " wins");
                        goto EndGame;
                    }
                }
            }
            cont2 = 0;
            if (R + C == 2)//To Check The Diagonally
            {
                for (int i = 0, j = 2; i < 3; i++, j--)
                {
                    if (RC[i, j] == s)
                    {
                        cont2++;
                    }
                    else
                    {
                        break;
                    }
                    if (cont2 == 3)
                    {
                        Console.WriteLine(player + " wins");
                        goto EndGame;
                    }
                }
            }
        EndGame:
            if (cont2 == 3)
            {
                Console.WriteLine("End Game");
                //GameScene(RC);
                return true;
            }
            else
            {
                return false;
            }
        }
        static int RandC(string Block,string choice)
        {
            int r=10, c=10;
            switch(Block)
            {
                case "1":
                    r = 0;
                    c = 0;
                    break;
                case "2":
                    r = 0;
                    c = 1;
                    break;
                case "3":
                    r = 0;
                    c = 2;
                    break;
                case "4":
                    r = 1;
                    c = 0;
                    break;
                case "5":
                    r = 1;
                    c = 1;
                    break;
                case "6":
                    r = 1;
                    c = 2;
                    break;
                case "7":
                    r = 2;
                    c = 0;
                    break;
                case "8":
                    r = 2;
                    c = 1;
                    break;
                case "9":
                    r = 2;
                    c = 2;
                    break;
                default:
                    Console.WriteLine("enter valid option");
                    break;
            }
            if(choice=="r")
            {
                return r;
            }
            else
            {
                return c;
            }
        }
    }
}
