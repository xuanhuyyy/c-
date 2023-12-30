using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19_xay_dung_lop_va_cac_thanh_phan_cua_lop
{
    public class SinhVien
    {
        #region cac bien lop
        private int ma;
        private string ten;
        private DateTime namsinh;
        #endregion
        #region constructor
        public SinhVien()
        {
            this.ma = 1;
            this.ten = "Huy";
        }
        public SinhVien(int ma, string ten, DateTime namsinh)
        {
            this.ma = ma;
            this.ten = ten;
            this.namsinh = namsinh;
        }
        #endregion
        #region properties
        public int Ma
        {
            get { return this.ma; }
            set { this.ma = value; }
        }
        public string Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }
        public DateTime Namsinh
        {
            get { return this.namsinh; }
            set { this.namsinh = value;}
        }
        #endregion
        #region phuong thuc
        public override string ToString()
        {
            return this.ma + "\t" + this.ten+"\t"+this.namsinh.ToString("dd/MM/yyyy");
        }
        #region support method
        private bool KiemTraNamSinh()
        {
            return (DateTime.Now.Year - this.namsinh.Year >= 17);
        }
        #endregion
        public void XuatThongTin()
        {
            if(KiemTraNamSinh() == false) {
                Console.WriteLine("Sinh vien chua du 18");
            }
            else
            {
                Console.WriteLine(ToString());
            }
        }
        #endregion
        #region Overloading
        public void XuatSinhVien(int x)
        {

        }
        public void XuatSinhVien(float x)
        {

        }
        #endregion
    }
}
