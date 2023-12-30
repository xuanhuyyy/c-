namespace Bai19_xay_dung_lop_va_cac_thanh_phan_cua_lop
{
    internal class Program
    {
        static void TestLop()
        {
            SinhVien sinhVien = new SinhVien();
            while (true)
            {
                try
                {
                    Console.WriteLine(sinhVien);
                    Console.WriteLine("Nhap ma, ten, ngay sinh sinh vien: ");
                    Console.Write("Ma: ");
                    sinhVien.Ma = int.Parse(Console.ReadLine());
                    Console.Write("Ten: ");
                    sinhVien.Ten = Console.ReadLine();
                    Console.Write("Ngay sinh: ");
                    sinhVien.Namsinh = DateTime.Parse(Console.ReadLine());
                    sinhVien.XuatThongTin();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Vui long nhap dung dinh dang ngay sinh");
                }
            }
        }
        static void TestParams()
        {
            SanPham test = new SanPham();
            Console.WriteLine(test.Sum(1,2,3,4));
            Console.WriteLine(test.Sum());
            Console.WriteLine(test.Sum(-4, 6));
        }
        static void TestKhachHang()
        {
            List<KhachHang> dsKH = new List<KhachHang>();
            dsKH.Add(new KhachHang()
            {
                Ma = 1,
                Ten = "Huy",
                phone = "1"
            });
            KhachHang huy = new KhachHang();
            huy.Ma = 2;
            huy.Ten = "Le Xuan";
            huy.phone = "2";
            dsKH.Add(huy);
            dsKH.Add(new KhachHang()
            {
                Ma = 3,
                Ten = "Le",
                phone = "3"
            });
            foreach(KhachHang kh in dsKH)
            {
                Console.WriteLine(kh.Ma+"\t"+kh.Ten+"\t\t"+kh.phone);
            }
        }
        static void TestAlias()
        {
            KhachHang huy = new KhachHang();
            huy.Ma = 2;
            huy.Ten = "Le Xuan";
            huy.phone = "2";
            KhachHang le = new KhachHang();
            le.Ma = 2;
            le.Ten = "Le";
            le.phone = "2";
            huy = le;
            Console.WriteLine("Ten cua huy la " + huy.Ten);
            huy.Ten = "Xuan";
            Console.WriteLine("Ten cua le la " + le.Ten);
        }
        static void Main(string[] args)
        {
            //TestLop();
            //TestParams();
            //TestKhachHang();
            TestAlias();
        }
    }
}
