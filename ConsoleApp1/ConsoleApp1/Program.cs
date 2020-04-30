using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру в соответствии с выбранной фигурой:");
            Console.WriteLine("Куб - 1" +
                "\nПрямоугольный параллелепипед - 2" +
                "\nЦилиндр - 3" +
                "\nПирамида - 4" +
                "\nУсеченная пирамида - 5" +
                "\nПолый цилиндр - 6" +
                "\nКонус - 7" +
                "\nУсеченный конус - 8" +
                "\nШар - 9");
            int figura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифру в соответствии с выбранным действием:");
            Console.WriteLine("Объём фигуры - 1" +
                "\nПлощадь полной поверхности - 2");
            int vich = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (figura)
                {
                    case 1:
                        if (vich == 1)
                        {
                            //Объём куба
                            Console.Write("Введите сторону куба: ");
                            double akyb = Convert.ToDouble(Console.ReadLine());
                            double vkyb = Math.Pow(akyb, 3);
                            Console.WriteLine("Объём куба равен: " + vkyb);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности куба
                            Console.Write("Введите сторону куба: ");
                            double akybp = Convert.ToDouble(Console.ReadLine());
                            double skyb = 6 * Math.Pow(akybp, 2);
                            Console.WriteLine("Площадь полной поверхности куба равна: " + skyb);
                        }
                        break;
                    case 2:
                        if (vich == 1)
                        {
                            //Объём прямоугольного параллелепипеда
                            Console.Write("Введите сторону прямоугольного параллелепипеда: ");
                            double ap = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите сторону прямоугольного параллелепипеда: ");
                            double bp = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите сторону прямоугольного параллелепипеда: ");
                            double cp = Convert.ToDouble(Console.ReadLine());
                            double vp = ap * bp * cp;
                            Console.WriteLine("Объём прямоугольного параллелепипеда равен: " + vp);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности прямоугольного параллелепипеда
                            Console.Write("Введите сторону прямоугольного параллелепипеда: ");
                            double ap1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите сторону прямоугольного параллелепипеда: ");
                            double bp1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите сторону прямоугольного параллелепипеда: ");
                            double cp1 = Convert.ToDouble(Console.ReadLine());
                            double sp = 2 * (ap1 * bp1 + bp1 * cp1 + ap1 * cp1);
                            Console.WriteLine("Площадь полной поверхности прямоугольного параллелепипеда равна: " + sp);
                        }
                        break;
                    case 3:
                        if (vich == 1)
                        {
                            //Объём цилиндра
                            Console.Write("Введите высоту цилиндра: ");
                            double hc = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите радиус цилиндра: ");
                            double rc = Convert.ToDouble(Console.ReadLine());
                            double vc = Math.PI * Math.Pow(rc, 2) * hc;
                            Console.WriteLine("Объём цилиндра равен: " + vc);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности цилиндра
                            Console.Write("Введите высоту цилиндра: ");
                            double hc1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите радиус цилиндра: ");
                            double rc1 = Convert.ToDouble(Console.ReadLine());
                            double sc = 2 * Math.PI * rc1 * (rc1 + hc1);
                            Console.WriteLine("Площадь полной поверхности цилиндра равна: " + sc);
                        }
                        break;
                    case 4:
                        if (vich == 1)
                        {
                            //Объём пирамиды
                            Console.Write("Введите высоту пирамиды: ");
                            double hpi = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите сторону пирамиды: ");
                            double api = Convert.ToDouble(Console.ReadLine());
                            double vpi = hpi * api / 3;
                            Console.WriteLine("Объём пирамиды равен: " + vpi);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности пирамиды
                            Console.WriteLine("Формулы для площади полной поверхности пирамиды не существует");
                        }
                        break;
                    case 5:
                        if (vich == 1)
                        {
                            //Объём усеченной пирамиды
                            Console.Write("Введите высоту усеченной пирамиды: ");
                            double hupi = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите нижнюю сторону усеченной пирамиды: ");
                            double aupi = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите верхнюю сторону усеченной пирамиды: ");
                            double bupi = Convert.ToDouble(Console.ReadLine());
                            double vupi = hupi * (aupi + bupi + Math.Sqrt(aupi * bupi)) / 3;
                            Console.WriteLine("Объём усеченной пирамиды равен: " + vupi);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности усеченной пирамиды
                            Console.WriteLine("Формулы для площади полной поверхности усеченной пирамиды не существует");
                        }
                        break;
                    case 6:
                        if (vich == 1)
                        {
                            //Объём полого цилиндра
                            Console.Write("Введите высоту цилиндра: ");
                            double hpc = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите диаметр внутренней окружности цилиндра: ");
                            double dvpc = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите диаметр основания цилиндра: ");
                            double dopc = Convert.ToDouble(Console.ReadLine());
                            double vpc = Math.PI * hpc * (Math.Pow(dopc, 2) - Math.Pow(dvpc, 2)) / 4;
                            Console.WriteLine("Объём полого цилиндра равен: " + vpc);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности полого цилиндра
                            Console.WriteLine("Формулы для площади полной поверхности полого цилиндра не существует");
                        }
                        break;
                    case 7:
                        if (vich == 1)
                        {
                            //Объём конуса
                            Console.Write("Введите высоту конуса: ");
                            double hk = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите радиус конуса: ");
                            double rk = Convert.ToDouble(Console.ReadLine());
                            double vk = Math.PI * Math.Pow(rk, 2) * hk / 3;
                            Console.WriteLine("Объём конуса равен: " + vk);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности конуса
                            Console.Write("Введите длину поверхости конуса: ");
                            double lk = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите радиус конуса: ");
                            double rk = Convert.ToDouble(Console.ReadLine());
                            double sk = Math.PI * (rk + lk);
                            Console.WriteLine("Площадь полной поверхности конуса равна: " + sk);
                        }
                        break;
                    case 8:
                        if (vich == 1)
                        {
                            //Объём усеченного конуса
                            Console.Write("Введите высоту усеченного конуса: ");
                            double huk = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите длину поверхости усеченного конуса: ");
                            double luk = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите верхний радиус усеченного конуса: ");
                            double wruk = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите нижний радиус усеченного конуса: ");
                            double nruk = Convert.ToDouble(Console.ReadLine());
                            double vuk = Math.PI * huk * (Math.Pow(wruk, 2) + Math.Pow(nruk, 2) + wruk * nruk) / 3;
                            Console.WriteLine("Объём усеченного конуса равен: " + vuk);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности усеченного конуса
                            Console.Write("Введите высоту усеченного конуса: ");
                            double huk1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите длину поверхости усеченного конуса: ");
                            double luk1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите верхний радиус усеченного конуса: ");
                            double wruk1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите нижний радиус усеченного конуса: ");
                            double nruk1 = Convert.ToDouble(Console.ReadLine());
                            double suk = Math.PI * (Math.Pow(wruk1, 2) + Math.Pow(nruk1, 2) + luk1 * (wruk1 + nruk1));
                            Console.WriteLine("Площадь полной поверхности усеченного конуса равна: " + suk);
                        }
                        break;
                    case 9:
                        if (vich == 1)
                        {
                            //Объём шара
                            Console.Write("Введите радиус шара: ");
                            double rsh = Convert.ToDouble(Console.ReadLine());
                            double vsh = 4 * Math.PI * Math.Pow(rsh, 3) / 3;
                            Console.WriteLine("Объём шара равен: " + vsh);
                        }
                        else if (vich == 2)
                        {
                            //Площадь полной поверхности шара
                            Console.Write("Введите радиус шара: ");
                            double rsh1 = Convert.ToDouble(Console.ReadLine());
                            double ssh = 4 * Math.PI * Math.Pow(rsh1, 2);
                            Console.WriteLine("Объём шара равен: " + ssh);
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так!");
            }
            Console.ReadKey();   
        }
    }
}
