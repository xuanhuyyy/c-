using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_Ke_thua
{
    public class NhanVienThoiVu:NhanVien
    {
        public override void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("3");
        }
    }
}
