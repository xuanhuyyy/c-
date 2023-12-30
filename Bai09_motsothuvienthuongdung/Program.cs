using System.Text;

namespace Bai09_motsothuvienthuongdung
{
    internal class Program
    {
        static void Testtoanhoc()
        {
            //Giup nhan dien tieng viet
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Can bac 2 cua {0} = {1}", a, Math.Sqrt(a));

            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}^{1} = {2}", a, b, Math.Pow(a, b));

            Console.WriteLine("Nhap goc: ");
            int goc = int.Parse(Console.ReadLine());
            double radian = Math.PI * goc / 180;
            Console.WriteLine("Sin({0}) = {1}", a, Math.Sin(radian));
            Console.WriteLine("cos({0}) = {1}", a, Math.Cos(radian));

            Console.WriteLine("Nhap x: ");
            double x = 7.75335;
            Console.WriteLine("x ban dau {0}", x);
            Console.WriteLine("x sau khi lam tron {0}",Math.Round(x,2));
        }
        static void TestRandom()
        {
            Random rd = new Random();
            int x = rd.Next(101);
            Console.WriteLine("Xuat so ngau nhien trong doan [0; 100] = {0}", x);

            double d = rd.NextDouble();
            Console.WriteLine("Xuat so ngau nhien trong doan [0, 1) = {0}", d);

            int y = rd.Next(50, 150);
            Console.WriteLine("Xuat so ngau nhien trong doan [50, 150]");
        }
        static void TestDateTime()
        {
            DateTime birthday = new DateTime(2003, 11, 25);
            Console.WriteLine(birthday.ToString("dd/MM/yyyy"));

            DateTime d = DateTime.Parse("25/11/2003");
            Console.WriteLine(d.ToString("dd/MM/yyyy"));

            while(true)
            {
                Console.WriteLine("Moi ban nhap ngay sinh: ");
                try
                {
                    string s = Console.ReadLine();
                    DateTime bd = DateTime.Parse(s);
                    Console.WriteLine("Ban sinh ngay " + bd.Day);
                    Console.WriteLine("Ban sinh thang " + bd.Month);
                    Console.WriteLine("Ban sinh nam " + bd.Year);
                    Console.WriteLine("Ngay sinh cua ban " + bd.ToString("dd/MM/yyyy"));
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Vui long nhap dung ngay thang nam sinh cua ban");
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            //Testtoanhoc();
            //TestRandom();
            TestDateTime();
        }
    }
}
