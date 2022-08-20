using System;

using System.Text;

namespace ChDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Enter your digit:");

            char[] N = Console.ReadLine().ToCharArray();


            //if (N.Contains('一') || N.Contains('一'))

                if (@"零一二两三四五六七八九十百千万".Any(N.Contains))
                { 

            //One-digit number control 

            if (N.Length == 1)
            {
                char uno = N[0];
                Console.WriteLine(getInteger1(uno));
            }




            //Two-digit number control 

            if (N.Length == 2)

            {


                if (N[1] == '十')
                {

                    char uno = N[0];

                    Console.WriteLine(getInteger1(uno) + "0");
                }



                if (N[0] == '十')
                {
                    char uno = N[1];

                    Console.WriteLine("1" + getInteger1(uno));
                }




                if (N[1] == '百')
                {
                    char uno = N[0];

                    Console.WriteLine(getInteger1(uno) + "00");
                }


                    if (N[1] == '千')
                    {
                        char uno = N[0];

                        Console.WriteLine(getInteger1(uno) + "000");
                    }


                    if (N[1] == '万')
                    {
                        char uno = N[0];

                        Console.WriteLine(getInteger1(uno) + "0000");
                    }

                    if (N[1] == '亿')
                    {
                        char uno = N[0];

                        Console.WriteLine(getInteger1(uno) + "00000000");
                    }
                }


                //Three-digit number control 


                if (N.Length == 3 && N[1] == '十')
            {
                char uno = N[0];
                char tre = N[2];
                Console.WriteLine(getInteger1(uno) +""+ getInteger1(tre));

            }


            //Four-digit number control 
            if (N.Length == 4 && N[2] == '零' && N[1] == '百')
            {
                char uno = N[0];
                char tre = N[3];
              
                Console.WriteLine(getInteger1(uno) + "0" + getInteger1(tre));

            }


            //Five-digit number control 
            if (N.Length == 5 && N[3] == '十' && N[1] == '百')
            {
                char uno = N[0];
                char tre = N[2];
                char quattro = N[4];
                Console.WriteLine(getInteger1(uno)  + ""+ getInteger1(tre) + "" + getInteger1(quattro));

            }

                //Seven-digit number control 
                if (N.Length == 7 && N[1] == '千' && N[5] == '十' && N[3] == '百')
                {
                    char uno = N[0];
                    char tre = N[2];
                    char quattro = N[4];
                    char sei = N[6];
                    Console.WriteLine(getInteger1(uno) + "" + getInteger1(tre) + "" + getInteger1(quattro) + "" + getInteger1(sei));

                }


                //Nina-digit number control 
                if (N.Length == 9 && N[1] == '万' && N[5] == '百' && N[3] == '千' && N[7] == '十')
                {
                    char uno = N[0];
                    char tre = N[2];
                    char quattro = N[4];
                    char sei = N[6];
                    char otto = N[8];
                    Console.WriteLine(getInteger1(uno) + "" + getInteger1(tre) + "" + getInteger1(quattro) + "" + getInteger1(sei) + "" + getInteger1(otto));

                }





            }
            static int getInteger1(char uno)
            {

                switch (uno)
                {
                    case '零': return 0;
                    case '一': return 1;
                    case '二': return 2;
                    case '两': return 2;
                    case '三': return 3;
                    case '四': return 4;
                    case '五': return 5;
                    case '六': return 6;
                    case '七': return 7;
                    case '八': return 8;
                    case '九': return 9;
                    case '十': return 10;
                    case '白': return 100;
                    case '千': return 1000;
                    case '万': return 10000;
                    default: return 0;
                }
            }
            }
        }
    }
