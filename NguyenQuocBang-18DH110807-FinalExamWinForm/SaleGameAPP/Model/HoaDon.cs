using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleGameAPP.Model
{
    class HoaDon
    {
        private string mSDH;
        private string mSNV;
        private DateTime ngayDat;

        public string MSDH { get => mSDH; set => mSDH = value; }
        public string MSNV { get => mSNV; set => mSNV = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
    }
}
