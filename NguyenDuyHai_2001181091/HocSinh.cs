using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHai_2001181091
{
    class HocSinh
    {
        private float diemToan, diemLy, diemHoa;
        private float diemRenLuyen;

        public float DiemToan { get => diemToan; set => diemToan = value >= 0 ? value:0; }
        public float DiemLy { get => diemLy; set => diemLy = value >= 0 ? value : 0; }
        public float DiemHoa { get => diemHoa; set => diemHoa = value >= 0 ? value : 0; }
        public float DiemRenLuyen { get => diemRenLuyen; set => diemRenLuyen = value >= 0 ? value : 0; }

        public HocSinh(float diemToan, float diemLy, float diemHoa, float diemRenLuyen)
        {
            this.DiemToan = diemToan;
            this.DiemLy = diemLy;
            this.DiemHoa = diemHoa;
            this.DiemRenLuyen = diemRenLuyen;
        }
        public float DiemTB
        {
            get
            {
                return (diemToan + diemLy + diemHoa) / 3;
            }
        }

        
        
        private int XepLoaiTheoDiem(float diem)
        {
            int xepLoai;
            if (diem < 5)
                xepLoai = 0;
            else if (diem < 6.5)
                xepLoai = 1;
            else if (diem < 8.0)
                xepLoai = 2;
            else
                xepLoai = 3;
            return xepLoai;
        }
        public string XepLoaiTrungBinhMon()
        {
            int xepLoai = 0;
            if (diemToan < 3.0 || DiemLy < 3.0 || diemHoa < 3.0)
                return "Yeu";

            xepLoai = XepLoaiTheoDiem(DiemTB);
            if (xepLoai > 1)
            {
                int xepLoaiDiemRL = XepLoaiTheoDiem(diemRenLuyen);
                if (xepLoaiDiemRL < xepLoai || XepLoaiTheoDiem(diemToan) < 1 || XepLoaiTheoDiem(diemLy) < 1 || XepLoaiTheoDiem(diemHoa) < 1)
                {
                    xepLoai--;
                }
            }

            switch (xepLoai)
            {
                case 0: return "Yeu";
                case 1: return "Trung Binh";
                case 2: return "Kha";
                case 3: return "Gioi";
            }
            return null;
        }
    }
}
