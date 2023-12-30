namespace Bai11_Debug_trong_C_
{
    internal class Program
    {
        //ax^2+bx+c=0
        static void Phuongtrinhbachai(double a, double b, double c)
        {
            if (a == 0)
            {
                if ((b == 0))
                {
                    if ((c == 0)){
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem "+(-c/b));
                }
            }
            else
            {
                double delta = b*b - 4*a*c;
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }else if (delta == 0) {
                    Console.WriteLine("Phuong trinh co nghiem kep "+(-b/2*a));
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem x1 = {0}; x2 = {1}",x1, x2);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Insert BreakPoint\n" +
                "2. F11\n" +
                "3. F10");
            Phuongtrinhbachai(2,5,-7);
        }
    }
}
