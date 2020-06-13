using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleGameAPP.Model
{
    class TaiKhoan
    {
        private string mSNV;
        private string tenTaiKhoan;
        private string matKhau;
        private string chiaKhoa;
        private string iV;

        public string MSNV { get => mSNV; set => mSNV = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string ChiaKhoa { get => chiaKhoa; set => chiaKhoa = value; }
        public string IV { get => iV; set => iV = value; }
    }
}
