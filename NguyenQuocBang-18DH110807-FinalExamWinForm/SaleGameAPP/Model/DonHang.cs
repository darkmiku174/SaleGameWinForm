using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleGameAPP.Model
{
    class DonHang
    {
        private string mSDH;
        private string mSHH;
        private int soLuong;
        private int tiLeGiam;

        public string MSDH { get => mSDH; set => mSDH = value; }
        public string MSHH { get => mSHH; set => mSHH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int TiLeGiam { get => tiLeGiam; set => tiLeGiam = value; }
    }
}
