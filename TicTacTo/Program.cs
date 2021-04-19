using System;

namespace TicTacTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] RC=new string[3,3];
            string flag = null;
            int cont1=1, cont2;
            while(cont1!=10)
            {
                player1:
                Console.WriteLine("player 1 enter ur row and col");
                string r = Console.ReadLine();
                string c = Console.ReadLine();
                int R = Int32.Parse(r);
                int C = Int32.Parse(c);
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
                if(cont1==10)
                {
                    break;
                }//To Check The Moves are over or not
                cont2 = 0;
                for (int i = 0; i < 3; i++)//To Check The whether the row is filled or not
                {
                    if (RC[R, i] == "x")
                    {
                        cont2++;
                    }
                    else
                    {
                        break;
                    }
                    if (cont2 == 3)
                    {
                        Console.WriteLine("player one wins");
                        flag = "Game Over";
                        goto EndGame;
                    }
                }
                cont2 = 0;
                for (int i = 0; i < 3; i++)//To Check The whether the Col is filled or not
                {

                    if (RC[i, C] == "x")
                    {
                        cont2++;
                    }
                    if (cont2 == 3)
                    {
                        Console.WriteLine("player one wins");
                        flag = "Game Over";
                        goto EndGame;
                    }
                }
                cont2 = 0;
                if (R == C)//To Check The Diagonally
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (RC[i, i] == "x")
                        {
                            cont2++;
                        }
                        else
                        {
                            break;
                        }
                        if (cont2 == 3)
                        {
                            Console.WriteLine("player one wins");
                            flag = "Game Over";
                            goto EndGame;
                        }
                    }
                }
                cont2 = 0;
                if (R + C == 2)//To Check The Diagonally
                {
                    for (int i = 0, j = 2; i < 3; i++, j--)
                    {
                        if (RC[i, j] == "x")
                        {
                            cont2++;
                        }
                        else
                        {
                            break;
                        }
                        if (cont2 == 3)
                        {
                            Console.WriteLine("player one wins");
                            flag = "Game Over";
                            goto EndGame;
                        }
                    }
                }
                Console.WriteLine("Game Scene");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
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
                }
                

                player2:
                Console.WriteLine("player 2 enter ur row and col");
                string r1 = Console.ReadLine();
                string c1 = Console.ReadLine();
                int R1 = Int32.Parse(r1);
                int C1 = Int32.Parse(c1);
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
                if (cont1 == 10)
                {
                    break;
                }
                cont2 = 0;
                for (int i = 0; i < 3; i++)//To Check The whether the row is filled or not
                {
                    if (RC[R1, i] == "o")
                    {
                        cont2++;
                    }
                    if (cont2 == 3)
                    {
                        Console.WriteLine("player Two wins");
                        flag = "Game Over";
                        goto EndGame;
                    }
                }
                cont2 = 0;
                for (int i = 0; i < 3; i++)//To Check The whether the Col is filled or not
                {

                    if (RC[i, C1] == "o")
                    {
                        cont2++;
                    }
                    if (cont2 == 3)
                    {
                        Console.WriteLine("player Two wins");
                        flag = "Game Over";
                        goto EndGame;
                    }
                }
                cont2 = 0;
                if (R1 == C1)//To Check The Diagonally
                {
                        for (int i = 0; i < 3; i++)
                        {
                            if (RC[i, i] == "o")
                            {
                                cont2++;
                            }
                            else
                            {
                                break;
                            }
                            if (cont2 == 3)
                            {
                                Console.WriteLine("player Two wins");
                                flag = "Game Over";
                                goto EndGame;
                            }
                        }
                }
                cont2 = 0;
                if (R1+C1 == 2)//To Check The Diagonally
                {
                    for (int i = 0, j = 2; i < 3; i++, j--)
                    {
                        if (RC[i, j] == "o")
                        {
                            cont2++;
                        }
                        else
                        {
                            break;
                        }
                        if (cont2 == 3)
                        {
                            Console.WriteLine("player Two wins");
                            flag = "Game Over";
                            goto EndGame;
                        }
                    }
                }
                    cont2 = 0;
                Console.WriteLine("Game Scene");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
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
                }

            }
            EndGame:
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
            }
        }
    }
}
