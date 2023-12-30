using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_Ke_thua
{
    public class HinhChuNhat
    {
        public int CanhA { get; set; }
        public int CanhB { get; set; }
        public HinhChuNhat(int canhA, int canhB) {
            CanhA = canhA;
            CanhB = canhB;
        }
        public virtual int Dientich()
        {
            return CanhA*CanhB;
        }
        public virtual int ChuVi()
        {
            return (CanhA + CanhB)*2;
        }
    }
}
