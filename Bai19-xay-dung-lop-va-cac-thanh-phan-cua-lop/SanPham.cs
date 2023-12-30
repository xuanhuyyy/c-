using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19_xay_dung_lop_va_cac_thanh_phan_cua_lop
{
    public class SanPham
    {
        #region Parameters
        public int Sum(params int []arr)
        {
            int s = 0;
            foreach (int x in arr)
            {
                s += x;
            }
            return s;
        }
        #endregion
    }
}
