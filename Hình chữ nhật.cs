using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class Hình_chữ_nhật
    {
        public double chieudai;
        public double chieurong;

        public double tinhdientich()
        {
            return chieudai * chieurong;
        }
        public double tichchuvi()
        {
            return (chieudai+chieurong)*2;
        }
    }
}
