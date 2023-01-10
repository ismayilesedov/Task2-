using System;
using System.Diagnostics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task8();


        }

        static void task1()
        {
            //verilmish 4 reqemli ededin reqemlerinin cemini tap
            Console.WriteLine("       Programa xosh gelmisiniz");
            int a;
            int cem = 0;
                int son;
            label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue=Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a)!=true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto label1;
            }
            if (a>999&&a<=9999)
            {
                while (a>0)
                {
                    son = a % 10;
                    a = a / 10;
                    cem += son;
                   
                }
                Console.WriteLine("Reqemlerin cemi :"+cem);
            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }


          
        }
        static void task2()
        {
            //verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap:
            Console.WriteLine("      Programa xosh gelmisiniz");
            int a;
            int cem = 0;
            int son;
            label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a)!=true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto label1;
            }
            if (a>99999&&a<=999999)
            {
                a = a / 1000;
                while (a > 0)
                {
                    
                    son = a % 10;
                    a = a / 10;
                    cem += son;
                    
                }
                Console.WriteLine(cem);

            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }
           
        }
        static void task3()
        {
            //verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
            Console.WriteLine("     Programa xosh gelmisiniz");
            int a;
            int son;
            int cem = 0;
        label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a)!=true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto label1;
            }
            if (a>99999999&&a<=999999999)
            {
                a = a / 1000;
                a = a % 1000;

                while (a>0)
                {
                    son = a % 10;
                    a = a / 10;
                    cem += son;
          
                }
                Console.WriteLine(cem);
            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }

        }
        static void task4()
        {
            //verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
            Console.WriteLine("    Programa xosh gelmisiniz");
            int a;
            int numL;
            int numF;
            int sum;
            label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);

            if (!int.TryParse(inputvalue, out a))
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto label1;
            }
            if (a>9999&&a<=99999)
            {
                numL = a % 10;
                numF = a / 10000;
                sum = (numL + numF) * (numL + numF);
                Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }

        } //problemim var menimsede bilmirem
        static void task5()
        {
            //verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            Console.WriteLine("            Programa xosh gelmisiniz");
            int a;
            int b;
        label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue,out a);
            if (int.TryParse(inputvalue, out a)!=true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto label1;
            }
            if (a>99999&&a<=999999)
            {
                b = a / 100000;
                a = a * 10;
                a = a + b;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }

        }
        static void task6()
        {
            //verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
            Console.WriteLine("           Programa xosh gelmisiniz ");
            int a;
            label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a)!=true)
            {
                Console.WriteLine("Tam ededi daxil edin");
            }
            if (a>9999999&&a<=99999999)
            {
                a = a / 10;
                a = a % 1000000;
               
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }

        }
        static void task7()
        {
            //verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
            Console.WriteLine("       Programa xosh gelmisiniz");
            int a;
            int reverse = 0;
            int sonreqem = 0;
            label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a)!=true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto label1;
            }
            if (a>999&&a<=9999)
            {
                while (a!=0)
                {
                    sonreqem = a % 10;
                    reverse = reverse * 10 + sonreqem;
                    a /= 10;               
                }
                reverse = reverse * 10;
                reverse = reverse + 8;
                reverse = reverse + 800000;
                Console.WriteLine(reverse);
            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }
        }
        static void task8()
        {
            Console.WriteLine("         Programa xosh gelmisiniz ");
            //Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  
            int a;
            int b;
            label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a)!=true)
            {
                Console.WriteLine("Tam eded daxil edin");
                goto label1;
            }
            if (a>99)
            {
                a = a % 1000;
                b = a % 10;
                a = a + b;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }
        }
        static void task9()
        {
            //9 reqemli ededdin tek yerde dayananlardan bir eded duzlet
            int a;
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a)!=true)
            {
                Console.WriteLine("Tam ededi daxil edin");
            }
            if (a>99999999&&a<=999999999)
            {
                for (int i = 0; i < a.lenght; i++)
                {


                }
            }
        }
    }
}