using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_Ke_thua
{
    public class NhanVien:ILamViec
    {
        public int Ma {  get; set; }
        public string Ten {  get; set; }

        public string LamViec(string mota)
        {
            string s = "Nhan vien dang " + mota;
            return s;
        }

        public virtual void TinhLuong()
        {
            Console.WriteLine("1");
        }
        public virtual int TinhLuong(int ngayCong)
        {
            return ngayCong * 100;
        }
    }
}
