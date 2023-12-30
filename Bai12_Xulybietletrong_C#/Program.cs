namespace Bai12_Xulybietletrong_C_
{
    internal class Program
    {
        static void HocBietLap1()
        {
            try
            {
                Console.WriteLine("Moi ban nhap ngay sinh: ");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("Ngay sinh cua ban: " + birthday.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nhap sai dinh dang ngay sinh");
            }
            finally
            {
                Console.WriteLine("Loi hay khong loi deu thuc hien het");
            }
        }
        static void HocBietLap2()
        {
            try
            {
                Console.WriteLine("Nhap tu: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mau: ");
                int b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    throw new ArithmeticException("Loi mau = 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("HocBietLap1 != HocBietLap2 o cho khi phat hien loi HocBietLap2 se nem loi ra luon ma khong can tinh toan");
            HocBietLap1();
            HocBietLap2();
        }
    }
}
