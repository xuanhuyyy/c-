namespace Bai13_Chuoi_va_cac_thaotac_tren_chuoi
{
    internal class Program
    {
        static void Ktrakytu()
        {
            Console.Write("Nhap ky tu 1: ");
            char c = char.Parse(Console.ReadLine());
            Console.Write("Nhap ky tu 2: ");
            char d = char.Parse(Console.ReadLine());
            Console.WriteLine(c.CompareTo(d));
            Console.WriteLine("Neu < 0 thi c < d\n" +
                "Neu = 0 thi c = d\n" +
                "Neu > 0 thi c > d");
            Console.WriteLine();
            Console.WriteLine("True neu ky tu 1 la chu so " + char.IsDigit(c));
            Console.WriteLine("True neu ky tu 1 la chu cai " + char.IsLetter(c));
            Console.WriteLine("True neu ky tu 1 la khoang trang " + char.IsWhiteSpace(c));
            Console.WriteLine("True neu ky tu 1 la chu thuong " + char.IsLower(c));
            Console.WriteLine("True neu ky tu 1 la chu hoa " + char.IsUpper(c));
        }
        static void Main(string[] args)
        {
            Ktrakytu();
        }
    }
}
