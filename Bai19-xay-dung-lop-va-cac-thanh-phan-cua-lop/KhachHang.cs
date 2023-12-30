using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19_xay_dung_lop_va_cac_thanh_phan_cua_lop
{
    public class KhachHang
    {
        public int Ma {  get; set; }
        public string Ten {  get; set; }
        public string phone {  get; set; }
        public KhachHang copy()
        {
            return this.MemberwiseClone() as KhachHang;
        }
    }
}
