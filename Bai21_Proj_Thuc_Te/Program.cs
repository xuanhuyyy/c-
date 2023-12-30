namespace Bai21_Proj_Thuc_Te
{
    internal class Program
    {
        static PhongBan phongBan = new PhongBan();
        static NhanVien nhanVien = new NhanVien();
        static void menu()
        {
            Console.Write("Nhap chuc nang: \n" +
                "1. Them phong ban, nhan vien\n" +
                "2. Sua phong ban, nhan vien\n" +
                "3. Xoa phong ban, nhan vien\n" +
                "4. Sap xep phong ban, nhan vien\n" +
                "5. Tim kiem\n" +
                "6. Hien thi\n" +
                "7. Thong ke luong 1 thang\n" +
                "8. Thoat\n" +
                "Nhap lua chon: ");
            int nhap = int.Parse(Console.ReadLine());
            switch (nhap)
            {
                case 1:
                    Them();
                    break;
            }
        }
        static void Them()
        {

        }
        static void Sua()
        {

        }
        static void HienThi()
        {
            phongBan.HienThi();
            nhanVien.HienThi();
        }
        static void TinhLuong()
        {
            nhanVien.TinhLuong();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
                Console.WriteLine("Nhan phim bat ky de thoat hoac 1 de tiep tuc");
                int nhap = int.Parse(Console.ReadLine());
                if (nhap != 1)
                {
                    break;
                }
            }
        }
    }
    public class PhongBan
    {
        static List<PhongBan> dsPb = new List<PhongBan>();
        private int mpb;
        private string tenPb;
        private NhanVien tenTp;
        public PhongBan(int mpb, string tenPb, NhanVien tenTp)
        {
            this.mpb = mpb;
            this.tenPb = tenPb;
            this.tenTp = tenTp;
        }
        public PhongBan() { }
        public int Mpb
        {
            set
            {
                this.mpb = value;
            }
            get
            {
                return this.mpb;
            }
        }
        public string TenPb
        {
            set { this.tenPb = value; }
            get { return this.tenPb; }
        }
        public NhanVien TenTp
        {
            set { this.tenTp = value; }
            get { return this.tenTp; }
        }
        public void Them(PhongBan pb)
        {
            foreach (PhongBan pbc in dsPb)
            {
                if (pbc.Mpb == pb.Mpb)
                {
                    Console.WriteLine("Da ton tai phong ban");
                }
            }
        }
        public virtual void Sua()
        {

        }
        public virtual void HienThi()
        {
            Console.WriteLine("Ma Phong Ban: " + this.Mpb);
            Console.WriteLine("Phong Ban: " + this.TenPb);
            Console.WriteLine("Truong Phong: " + this.TenTp);
        }
    }
    public class NhanVien : PhongBan
    {
        public PhongBan phongBan { get; set; }
        private int mnv;
        private string tenNv;
        private DateTime ngaySinh;
        private string chucVu;
        public NhanVien()
        {

        }
        public NhanVien(int mpb, string tenPb, string tenTp, int mnv, string tenNv, DateTime ngaySinh, string chucVu) : base(mpb, tenPb, tenTp)
        {
            this.mnv = mnv;
            this.tenNv = tenNv;
            this.ngaySinh = ngaySinh;
            this.chucVu = chucVu;
        }
        public double TinhLuong()
        {
            if (this.ChucVu == "Pho Phong".ToLower())
            {
                return 10000;
            }
            else if (this.ChucVu == "Giam Doc".ToLower())
            {
                return 10000 + (10000 * 25) / 100;
            }
            else if (this.ChucVu == "Truong Phong".ToLower())
            {
                return 10000 + (10000 * 15) / 100;
            }
            return 10000;
        }
        public int Mnv
        {
            set { this.mnv = value; }
            get { return this.mnv; }
        }
        public string TenNv
        {
            set { this.tenNv = value; }
            get { return this.tenNv; }
        }
        public DateTime NgaySinh
        {
            set { this.ngaySinh = value; }
            get { return this.ngaySinh; }
        }
        public string ChucVu
        {
            set { this.chucVu = value; }
            get
            {
                return this.chucVu;
            }
        }
        public override void Them()
        {
            base.Them();
            Console.Write("Ma Nhan Vien: ");
            this.Mnv = int.Parse(Console.ReadLine());
            Console.Write("Ten Nhan Vien: ");
            this.TenNv = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            this.NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Chuc Vu: ");
            this.ChucVu = Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Ma Nhan Vien: " + this.Mnv);
            Console.WriteLine("Ten Nhan Vien: " + this.TenNv);
            Console.WriteLine("Ngay sinh: " + this.Mnv.ToString("dd/MM/yyyy"));
            Console.WriteLine("Chuc Vu: " + this.ChucVu);
            Console.WriteLine("Luong: " + TinhLuong());
        }
    }
}
