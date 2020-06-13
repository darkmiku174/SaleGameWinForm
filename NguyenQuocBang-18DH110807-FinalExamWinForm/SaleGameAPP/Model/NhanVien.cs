using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleGameAPP.Model
{
    class NhanVien
    {
        private string mSNV;
        private string tenNV;
        private bool loai; //1 là nhân viên, 0 là chủ

        public string MSNV { get => mSNV; set => mSNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public bool Loai { get => loai; set => loai = value; }
    }
}
