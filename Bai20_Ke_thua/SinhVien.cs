using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_Ke_thua
{
    public class SinhVien : ILamViec
    {
        public int MaSV {  get; set; }
        public string TenSv { get; set; }
        public string LamViec(string mota)
        {
            string s = "Sv dang " + mota;
            return s;
        }
    }
}
