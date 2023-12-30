namespace Bai20_Ke_thua
{
    internal class Program
    {
        static void TestNhanVien()
        {
            NhanVien huy = new NhanVienChinhThuc();
            huy.TinhLuong();
            NhanVien le = new NhanVienThoiVu();
            le.TinhLuong();
        }
        static void TestNhanVien2()
        {
            NhanVien huy = new NhanVienChinhThuc();
            Console.WriteLine(huy.TinhLuong(18));
            Console.WriteLine(huy.TinhLuong(20));
        }
        static void TestHCNHV()
        {
            HinhChuNhat h1 = new HinhChuNhat(4,10);
            Console.WriteLine("Chu vi: "+h1.ChuVi());
            Console.WriteLine("Dien tich: "+h1.Dientich());

            HinhChuNhat h2 = new HinhVuong(4);
            Console.WriteLine("Chu vi: "+h2.ChuVi());
            Console.WriteLine("Dien tich: " + h2.Dientich());
        }
        static void TestInterface()
        {
            ILamViec huy = new NhanVien();
            Console.WriteLine(huy.LamViec("Hoc"));

            ILamViec huy1 = new SinhVien();
            Console.WriteLine(huy1.LamViec("Choi game"));
        }
        static void TestHocAsIs()
        {
            /*ILamViec huy = new NhanVien();
            if(huy is NhanVien)
            {
                Console.WriteLine("Huy la nv");
                NhanVien x = huy as NhanVien;
            }
            ILamViec huy1 = new SinhVien();*/
            List<ILamViec> ds = new List<ILamViec>();
            NhanVien huy = new NhanVien();
            huy.Ma = 1;
            huy.Ten = "huy";
            ds.Add(huy);
            SinhVien huy1 = new SinhVien();
            huy1.MaSV = 2;
            huy1.TenSv = "huy1";
            ds.Add(huy1);
            foreach(ILamViec v in ds)
            {
                if(v is NhanVien)
                {
                    NhanVien nv = v as NhanVien;
                    Console.WriteLine(nv.Ten);
                }else if (v is SinhVien)
                {
                    SinhVien sv = v as SinhVien;
                    Console.Write(sv.TenSv);
                }
            }
        }
        static void Main(string[] args)
        {
            //TestNhanVien();
            //TestNhanVien2();
            //TestHCNHV();
            //TestInterface();
            TestHocAsIs();
        }
    }
}
