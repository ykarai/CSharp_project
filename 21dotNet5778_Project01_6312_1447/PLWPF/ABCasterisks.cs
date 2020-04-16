using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLWPF
{
    class ABCasterisks
    {
      

            static String a = "";
            static int Row, Col;
            public static string p(char choice = 'a')
            {
                a = "";

                //char choice;
                //Console.WriteLine("Please Enter Any one Alphabate Which you want to print");
                //choice = char.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 'a':
                    case 'A':
                        A();
                        break;

                    case 'b':
                    case 'B':
                        B();
                        break;

                    case 'c':
                    case 'C':
                        C();
                        break;

                    case 'd':
                    case 'D':
                        D();
                        break;

                    case 'e':
                    case 'E':
                        E();
                        break;

                    case 'f':
                    case 'F':
                        F();
                        break;

                    case 'g':
                    case 'G':
                        G();
                        break;

                    case 'h':
                    case 'H':
                        H();
                        break;

                    case 'i':
                    case 'I':
                        I();
                        break;

                    case 'j':
                    case 'J':
                        J();
                        break;

                    case 'k':
                    case 'K':
                        K();
                        break;

                    case 'l':
                    case 'L':
                        L();
                        break;

                    case 'm':
                    case 'M':
                        M();
                        break;

                    case 'n':
                    case 'N':
                        N();
                        break;

                    case 'o':
                    case 'O':
                        O();
                        break;

                    case 'p':
                    case 'P':
                        P();
                        break;

                    case 'q':
                    case 'Q':
                        Q();
                        break;

                    case 'r':
                    case 'R':
                        R();
                        break;

                    case 's':
                    case 'S':
                        S();
                        break;

                    case 't':
                    case 'T':
                        T();
                        break;

                    case 'u':
                    case 'U':
                        U();
                        break;

                    case 'v':
                    case 'V':
                        V();
                        break;

                    case 'w':
                    case 'W':
                        W();
                        break;

                    case 'x':
                    case 'X':
                        X();
                        break;

                    case 'y':
                    case 'Y':
                        Y();
                        break;

                    case 'z':
                    case 'Z':
                        Z();
                        break;
                }


                return a;
                //a = "";
            }
            static void A()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Col == 1 || Col == 5) && Row != 0) || ((Row == 0 || Row == 3) && (Col > 1 && Col < 5)))
                            a += "*";
                        //Console.Write("*");

                        else
                            a += "  ";
                        //Console.Write(" ");
                    }
                    a += "\n";
                    // Console.WriteLine();
                }
            }
            static void B()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || ((Row == 0 || Row == 3 || Row == 6) && (Col < 5 && Col > 1)) || (Col == 5 && (Row != 0 && Row != 3 && Row != 6)))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void C()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if ((Col == 1 && (Row != 0 && Row != 6)) || ((Row == 0 || Row == 6) && (Col > 1 && Col < 5)) || (Col == 5 && (Row == 1 || Row == 5)))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void D()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || ((Row == 0 || Row == 6) && (Col > 1 && Col < 5)) || (Col == 5 && Row != 0 && Row != 6))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void E()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || ((Row == 0 || Row == 6) && (Col > 1 && Col < 6)) || (Row == 3 && Col > 1 && Col < 5))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void F()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || (Row == 0 && Col > 1 && Col < 6) || (Row == 3 && Col > 1 && Col < 5))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void G()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if ((Col == 1 && Row != 0 && Row != 6) || ((Row == 0 || Row == 6) && Col > 1 && Col < 5) || (Row == 3 && Col > 2 && Col < 6) || (Col == 5 && Row != 0 && Row != 2 && Row != 6))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void H()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if ((Col == 1 || Col == 5) || (Row == 3 && Col > 1 && Col < 6))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void I()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 3 || (Row == 0 && Col > 0 && Col < 6) || (Row == 6 && Col > 0 && Col < 6))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void J()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if ((Col == 4 && Row != 6) || (Row == 0 && Col > 2 && Col < 6) || (Row == 6 && Col == 3) || (Row == 5 && Col == 2))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void K()
            {
                int i, j;
                j = 5;
                i = 0;
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {

                        if (Col == 1 || ((Row == Col + 1) && Col != 0))
                        {
                            a += "*";
                        }
                        else if (Row == i && Col == j)
                        {
                            a += "*";
                            i++;
                            j--;
                        }
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void L()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || (Row == 6 && Col != 0 && Col < 6))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void M()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || Col == 5 || (Row == 2 && (Col == 2 || Col == 4)) || (Row == 3 && Col == 3))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void N()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || Col == 5 || (Row == Col && Col != 0 && Col != 6))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void O()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Col == 1 || Col == 5) && Row != 0 && Row != 6) || ((Row == 0 || Row == 6) && Col > 1 && Col < 5))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void P()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || ((Row == 0 || Row == 3) && Col > 0 && Col < 5) || ((Col == 5 || Col == 1) && (Row == 1 || Row == 2)))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void Q()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if ((Col == 1 && Row != 0 && Row != 6) || (Row == 0 && Col > 1 && Col < 5) || (Col == 5 && Row != 0 && Row != 5) || (Row == 6 && Col > 1 && Col < 4) || (Col == Row - 1 && Row > 3))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void R()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 1 || ((Row == 0 || Row == 3) && Col > 1 && Col < 5) || (Col == 5 && Row != 0 && Row < 3) || (Col == Row - 1 && Row > 2))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void S()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Row == 0 || Row == 3 || Row == 6) && Col > 1 && Col < 5) || (Col == 1 && (Row == 1 || Row == 2 || Row == 6)) || (Col == 5 && (Row == 0 || Row == 4 || Row == 5)))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void T()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (Col == 3 || (Row == 0 && Col > 0 && Col < 6))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void U()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Col == 1 || Col == 5) && Row != 6) || (Row == 6 && Col > 1 && Col < 5))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void V()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Col == 1 || Col == 5) && Row < 5) || (Row == 6 && Col == 3) || (Row == 5 && (Col == 2 || Col == 4)))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void W()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Col == 1 || Col == 5) && Row < 6) || ((Row == 5 || Row == 4) && Col == 3) || (Row == 6 && (Col == 2 || Col == 4)))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void X()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Col == 1 || Col == 5) && (Row > 4 || Row < 2)) || Row == Col && Col > 0 && Col < 6 || (Col == 2 && Row == 4) || (Col == 4 && Row == 2))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void Y()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Col == 1 || Col == 5) && Row < 2) || Row == Col && Col > 0 && Col < 4 || (Col == 4 && Row == 2) || ((Col == 3) && Row > 3))
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
            static void Z()
            {
                for (Row = 0; Row < 7; Row++)
                {
                    for (Col = 0; Col < 7; Col++)
                    {
                        if (((Row == 0 || Row == 6) && Col >= 0 && Col <= 6) || Row + Col == 6)
                            a += "*";
                        else
                            a += "  ";
                    }
                    a += "\n";
                }
            }
        }
    }







