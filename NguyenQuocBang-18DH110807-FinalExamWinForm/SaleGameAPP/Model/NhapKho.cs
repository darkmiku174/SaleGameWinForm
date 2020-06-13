using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleGameAPP.Model
{
    class NhapKho
    {
        private string mSNK;
        private string mSHH;
        private string mSNV;
        private DateTime ngayNhap;

        public string MSNK { get => mSNK; set => mSNK = value; }
        public string MSHH { get => mSHH; set => mSHH = value; }
        public string MSNV { get => mSNV; set => mSNV = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
    }
}
