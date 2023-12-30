using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_Ke_thua
{
    public class HinhVuong:HinhChuNhat
    {
        public HinhVuong(int A) : base(A, A)
        {
            
        }
        public override int Dientich()
        {
            return base.Dientich();
        }
        public override int ChuVi()
        {
            return base.ChuVi();
        }
    }
}
