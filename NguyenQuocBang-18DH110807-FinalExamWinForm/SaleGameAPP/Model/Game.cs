using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleGameAPP.Model
{
    class Game
    {
        private string mSHH;
        private string tenGame;
        private byte[] hinhAnh;
        private int gia;
        private bool tinhTrang;

        public string MSHH { get => mSHH; set => mSHH = value; }
        public string TenGame { get => tenGame; set => tenGame = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int Gia { get => gia; set => gia = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
