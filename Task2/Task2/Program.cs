using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void task1()
        {
            //verilmish 4 reqemli ededin reqemlerinin cemini tap
            Console.WriteLine("       Programa xosh gelmisiniz");
            label1:
            int a = cevirme();
            int cem = 0;
            int son;        
            if (a > 999 && a <= 9999)
            {
                while (a > 0)
                {
                    son = a % 10;
                    a = a / 10;
                    cem += son;

                }
                Console.WriteLine("Reqemlerin cemi :" + cem);
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
        label1:
            int a = cevirme();
            int cem = 0;
            int son;
            
            if (a > 99999 && a <= 999999)
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
        label1:
            int a = cevirme();
            int son;
            int cem = 0;
            
            if (a > 99999999 && a <= 999999999)
            {
                a = a / 1000;
                a = a % 1000;

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
        static void task4()
        {
            //verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
            Console.WriteLine("    Programa xosh gelmisiniz");
        label1:
            int a = cevirme();
            int numL;
            int numF;
            
       
            if (a > 9999 && a <= 99999)
            {
                numF= a / 10000;
                numL = a % 10;
                numF = numF + numL;
                
                numF = (numF * numF);
                Console.WriteLine(numF);

            }
            else
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }

        } 
        static void task5()
        {
            //verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            Console.WriteLine("            Programa xosh gelmisiniz");
            label1:
            int a=cevirme();
            int b;
        
            if (a > 99999 && a <= 999999)
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
        label1:
            int a=cevirme();
            if (a > 9999999 && a <= 99999999)
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
        label1:
            int a = cevirme();
            int reverse = 0;
            int sonreqem = 0;
            if (a > 999 && a <= 9999)
            {
                while (a != 0)
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
            label1:
            int a = cevirme();
            int b;
            if (a > 99)
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
            label1:
            int a = cevirme();
            int son;
            int reverse = 0;
            if (a < 99999999 || a > 1000000000)
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }
            else
            {
                while (a > 0)
                {
                    son = a % 10;
                    reverse = reverse * 10 + son;
                    a /= 10;
                }
                a = reverse;
                reverse = 0;
                int part1 = 0;

                int i = 1;

                while (a > 0)
                {
                    reverse = a % 10;
                    a /= 10;
                    if (i % 2 == 1)
                    {
                        part1 = part1 * 10 + reverse;
                    }
                    i++;
                }

                Console.WriteLine(part1);
            }
        }
        static void task10()
        {
            //9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            // sonra cut yerde dayanlarinda bir eded duzlet,
            //sonra onlari topla
            Console.WriteLine("            Programa xosh gelmisiniz");
            label1:
            int a = cevirme();
            int reverse = 0;
            int son;
            if (a < 99999999 || a > 1000000000)
            {
                Console.WriteLine("Duzgun ededi daxil edin");
                goto label1;
            }
            else
            {
                while (a > 0)
                {
                    son = a % 10;
                    reverse = reverse * 10 + son;
                    a /= 10;
                }
                a = reverse;
                reverse = 0;
                int part1 = 0; int part2 = 0;
                int i = 1;
                while (a > 0)
                {
                    son = a % 10;
                    a /= 10;
                    if (i % 2 == 0)
                    {

                        part1 = part1 * 10 + son;
                    }
                    else
                    {
                        part2 = part2 * 10 + son;
                    }
                    i++;
                }
                Console.WriteLine("Cut yerde duran ededler :" + part1);
                Console.WriteLine("Tek yerde duran ededler :" + part2);
                Console.WriteLine($"Bu ededlerin cemi:{part1} + {part2}={part1 + part2}");
            }
        }
        static void task11()
        {
            // 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            // Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            // Sonra cavabin ozunden onun 18 % ni cix;

            Console.WriteLine("    Programa xosh gelmisiniz ");
            label1:
            int a= cevirme();
            int son;
            int sum = 0;
            if (a>9999999&&a<=99999999)
            {
                while (a>0)
                {
                    son = a % 100;
                    sum += son;
                    a /= 100;
                }
                Console.WriteLine("Qruplarin cemi:" + sum);
                sum = (sum * 100) + 99;
                Console.WriteLine("Cavaba  axirina 99 artirdiq :" + sum);
                a = (sum * 18) / 100;
                sum = sum - a;
                Console.WriteLine("Yekun cavab :" + sum);
            }
            else
            {
                Console.WriteLine("Duzgun eded daxil et");
                goto label1;
            }

        }
        static void task12()

        {
            // 2 dene 5 reqemli eded daxil et.
            // I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
            //Neticenin axirina I ededin en axiinci reqemini artir.
            Console.WriteLine("Programa xosh gelmisiniz");
            int a = number6();
            label2:
            int b = number6();
            int son;
            int cem = 0;
            int hasil = 1;
            int temp = b;
                while (a > 0)
                {
                    son = a % 10;
                    a /= 10;
                    cem += son;

                }

                while (b > 0)
                {
                    son = b % 10;
                    b /= 10;
                    hasil *= son;

                }
                Console.WriteLine($"1 ci ededin reqemeri cemi={cem}");
                Console.WriteLine($"2 ci ededin reqemleri hasili={hasil}");
                cem = cem + hasil;
                Console.WriteLine($"hasilin ve cemin toplanmasicem={cem}");
                cem = cem * 10 + (temp % 10);
                Console.WriteLine($"son netice={cem}");
        }
        static void task13()
        {
            // 3 dene 5 reqemli eded var.
            // Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            // Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.
            Console.WriteLine("     Programa xosh gelmisiniz");
            label1:
            int a=number5(); double d; double x;
            int first1;
            int son1;
            int b=number5();
            int first2;
            int son2;
            int c = number5();
            int first3;
            int son3;        
           
                son1 = a % 10;
                first1 = a / 10000;
                son2 = b % 10;
                first2 = b / 10000;
                son3 = c % 10;
                first3 = c / 10000;
                first1 = first1 * 10 + son1;
                first2 = first2 * 10 + son2;
                first3 = first3 * 10 + son3;
                d = first1 + first2 + first3;
                x = (d * 50) / 100;
                d = d + x;
                Console.WriteLine("a ededinden emele gelen yeni eded :" + first1);
                Console.WriteLine("b ededinden emele gelen yeni eded :" + first2);
                Console.WriteLine("c ededinden emele gelen yeni eded :" + first3);
                Console.WriteLine("Umumi cavab :" + d);
        }
        static void task14()
        {
            //4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            // Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            //Neticenin 60 % tap.Cavabin axirina 60 artir.
            //Neticeden 18 % cix.
            double a = number6();
            double b = number6();
            double c = number6(); 
            double d = number7();
            double menimset; double dson; double son; double hasil = 1;        
                a = a / 1000;
                b = b / 1000;
                c = c / 1000;
                a = a + b + c;
                dson = d % 10000;
                a = a + dson;
                menimset = d / 10000;
                while (d > 0)
                {
                    son = d % 10;
                    d /= 10;
                    hasil *= son;
                }
                a = a - hasil;
                a = (a * 60) / 100;
                a = a * 100;
                a = a + 60;
                b = (a * 18) / 100;
                a = a - b;
                Console.WriteLine("Yekun cavab :" + a);         
        }
        static void task15()
        {
            // 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
            // 3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            // Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            //  Cavabdan 7 reqemli ededin son 5 reqemini cix.
            //  Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            //  Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            //  Cavabin axirina 11 artir.
            //   Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            //   Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.
            int y = number3(); int sum, son, son1, ters = 0, end;
            int x = number3();
            int z =number6();
            int t =number6();
            int s =number7();
            sum = y + x;
            son = sum % 100;
            son = son * son;
            son = son + y * 1000 + x;
            son = son - s % 100000;
            son = son + (z + t) % 1000;
            while (s > 0)
            {
                son1 = s % 10;
                sum += son1;
                s /= 10;


            }
            while (sum > 0)
            {
                son1 = sum % 10;
                ters = ters * 10 + son1;
                sum /= 10;

            }
            son = son + ters;
            son = son * 100 + 11;

            while (s > 0)
            {
                end = s % 10;
                ters = ters * 10 + end;
                s /= 10;
            }
            int i = 1, parttek = 0;
            while (ters > 0)
            {
                end = ters % 10;
                ters /= 10;
                if (i % 2 != 0)
                {
                    parttek = parttek * 10 + end;
                }
                i++;
            }
            son = son - parttek;
            sum = son % 10;
            son1 = son / 10;
            son = son1 * 1000 + 88 * 10 + sum;
            Console.WriteLine($"son netice={son}");


        }














        static int cevirme()
        {
            int a;
        label1:
            Console.WriteLine("Ededi daxil edin");
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto label1;
            }
            else
            {
                return a;
            }

        }

        





        static int number5()
        {
            label1:
            int a = cevirme();
            if (a>9999 && a<=99999)
            {
                return a;
            }
            else
            {
                Console.WriteLine("duzgun eded daxil edin");
                goto label1;
            }
            return a;
        }




        static int number6()
        {
            label1:
            int a = cevirme();
            if (a>99999&&a<=999999)
            {
                return a;
            }
            else
            {
                Console.WriteLine("duzgun eded daxil edin");
                goto label1;
            }
            return a;
        }


        static int number7()
        {
            label1:
            int a = cevirme();
            if (a > 999999 && a <= 9999999)
            {
                return a;
            }
            else
            {
                Console.WriteLine("duzgun eded daxil edin");
                goto label1;
            }
            return a;
        }



        static int number3()
        {
        label1:
            int a = cevirme();
            if (a > 99 && a <= 999)
            {
                return a;
            }
            else
            {
                Console.WriteLine("duzgun eded daxil edin");
                goto label1;
            }
            return a;
        }

    }
    












  

}