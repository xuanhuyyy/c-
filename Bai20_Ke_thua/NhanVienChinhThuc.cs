using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_Ke_thua
{
    public class NhanVienChinhThuc:NhanVien
    {
        public override void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("2");
        }
        public override int TinhLuong(int ngayCong)
        {
            if(ngayCong >= 20) {
                return 5000;
            }
            return base.TinhLuong(ngayCong);
        }
    }
}
