using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Text;
using System.Threading;

namespace project
{
    static class Program1
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()

        {
            int[,] squere = new int[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0, }, { 0, 0, 0, 0 } };
            List<int[,]> chapes = new List<int[,]>();
          
            /*first case*/

           /* int[,] chape1 = new int[2, 3] { { 1, 1, 1 }, { 1, 0, 1 } };
            int[,] chape2 = new int[4, 2] { { 0, 2 }, { 0, 2 }, { 2, 2 }, { 0, 2 } };
            int[,] chape3 = new int[2, 1] { { 3 }, { 3 } };
            int[,] chape4 = new int[3, 2] { { 4, 0 }, { 4, 0 }, { 4, 4 } }; */
            
            /* second case*/
/*
              int[,] chape1 = new int[1, 4] { { 1, 1, 1,1 } };
              int[,] chape2 = new int[1, 4] { { 2, 2, 2, 2 } };
              int[,] chape3 = new int[1, 4] { { 3, 3, 3, 3 } };
              int[,] chape4 = new int[2, 3] { { 4,4, 4 }, { 0, 0,4 } };*/

           /* third case*/
            
           int[,] chape1 = new int[2, 2] { { 1, 1 }, { 1, 1 } };
            int[,] chape2 = new int[2, 3] { { 2, 2, 2 }, { 2, 0, 0 } };
            int[,] chape3 = new int[3, 2] { { 3, 3 }, { 0, 3 }, { 0, 3 } };
            int[,] chape4 = new int[1, 3] { { 4, 4, 4 } };
            int[,] chape5 = new int[1, 1] { { 5 } };

            //  5 2 2 11 11 2 3 111 100 3 2 11 01 01 1 3 111 1 1 1


            chapes.Add(chape1);
            chapes.Add(chape2);
            chapes.Add(chape4);
            chapes.Add(chape3);
           chapes.Add(chape5);

           /* bool y;
            Thread one = new Thread(() => y = solvesquere(squere, chapes));
            one.Start();*/
            if (solvesquere(squere, chapes))
           // if(y)
            {

                Form1.square(squere);

                /*for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(squere[i, j]);
                    }
                    Console.WriteLine();
                }*/

            }
            else
            {

                Form1.square(squere);
                /*   Console.WriteLine("can't solve it");*/
            }



            //Console.ReadKey();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }



        public static bool solvesquere(int[,] squere, List<int[,]> chapes)
        {
            int count = chapes.Count;
            if (chapes.Count != 0)
            {
                for (int ch = 0; ch < chapes.Count; ch++)
                {

                    int[,] copy = new int[4, 4];
                    Array.Copy(squere, 0, copy, 0, copy.Length);
                    int[,] chepecopy = new int[chapes[ch].GetLength(0), chapes[ch].GetLength(1)];
                    Array.Copy(chapes[ch], 0, chepecopy, 0, chepecopy.Length);
                    chapes.RemoveAt(ch);
                    for (int j = 0; j < 2; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            /*bool z ;
                              bool x;
                            Thread four = new Thread(() => z = could(squere, chepecopy));
                            four.Start();*/
                           // if (z)

                                if (could(squere, chepecopy))
                            {
                              /*  Thread five = new Thread(() => x = could(squere, chepecopy));
                                five.Start();*/
                              //  if (x)
                                   if (solvesquere(squere, chapes))
                                {

                                    return true;
                                }
                                else
                                {


                                    Array.Copy(copy, 0, squere, 0, squere.Length);

                                    //chapes.Add(chepecopy);
                                }


                            }
                            Thread two = new Thread(() => chepecopy = rottate(chepecopy));
                            two.Start(); 
                            // chepecopy = rottate(chepecopy);
                        }
                        Thread three = new Thread(() => chepecopy = rottatehiroz(chepecopy));
                        three.Start();
                      //  chepecopy = rottatehiroz(chepecopy);
                    }
                    chapes.Add(chepecopy);


                }
                return false;

            }
            return true;
        }
        public static bool could(int[,] sq, int[,] ch)
        {

            int x = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (sq[i, j] == 0)
                    {
                        int r = j;

                        int[,] copy = new int[4, 4];
                        Array.Copy(sq, 0, copy, 0, copy.Length);
                        for (int i1 = 0; i1 < ch.GetLength(0); ++i1)
                        {

                            for (int j1 = 0; j1 < ch.GetLength(1); ++j1)
                            {
                                if (ch[i1, j1] != 0 && x == 0)
                                {
                                    j = j - j1;
                                    x = 1;
                                }
                                if (x == 1)
                                {
                                    if (r < 4 && r >= 0 && i < 4)
                                    {

                                        if (sq[i, r] != 0 && ch[i1, j1] != 0)
                                        {
                                            Array.Copy(copy, 0, sq, 0, sq.Length);
                                            return false;
                                        }
                                        else if (sq[i, r] == 0 && ch[i1, j1] != 0)
                                        {
                                            sq[i, r] = ch[i1, j1];

                                        }
                                    }
                                    else
                                    {

                                        Array.Copy(copy, 0, sq, 0, sq.Length);
                                        return false;
                                    }
                                    r++;
                                }

                            }
                            r = j;
                            i++;

                        }
                        return true;
                    }
                }
            }

            return false;

        }

        public static int[,] rottate(int[,] arr)
        {
            int[,] array = new int[arr.GetLength(1), arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int j1 = arr.GetLength(1) - 1;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    array[j1, i] = arr[i, j];
                    j1 = j1 - 1;
                }
            }
            return array;
        }
        public static int[,] rottatehiroz(int[,] arr)
        {
            int[,] array = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int j1 = arr.GetLength(1) - 1;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    array[i, j1] = arr[i, j];
                    j1 = j1 - 1;
                }
            }
            return array;
        }
    }
}
