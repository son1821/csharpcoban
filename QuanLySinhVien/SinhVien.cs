using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
     class SinhVien
    {
        public static int DemId = 1;
        public int Id { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public double DiemToan {  get; set; }
        public double DiemLy {  get; set; }
        public double DiemHoa { get;set; }
        public double DiemTrungBinh {  get; set; }
        public string HocLuc { get; set; }
        public SinhVien(string ten, string gioiTinh, int tuoi, double diemToan, double diemLy, double diemHoa)
        {
            Id = DemId++;
            Ten = ten;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            DiemTrungBinh = (diemToan + diemLy + diemHoa) / 3;
            HocLuc = TinhHocLuc(DiemTrungBinh);

        }
        public string TinhHocLuc(double DiemTrungBinh)
        {
            if (DiemTrungBinh >= 8)
            {
                return "Giỏi";
            }
            else if ( DiemTrungBinh >= 6.5)
            {
                return "Khá";
            }
            else if ( DiemTrungBinh >= 5)
            {
                return "Trung Bình";
            }
            else
            {
                return "Yếu";
            }
        }
        public void HienThiSinhVien()
        {
            Console.WriteLine("ID: "+Id);
            Console.WriteLine("Tên: "+Ten);
            Console.WriteLine("Giới Tính: "+GioiTinh);
            Console.WriteLine("Tuổi: "+Tuoi);
            Console.WriteLine("Điểm Toán: "+DiemToan);
            Console.WriteLine("Điểm Lý: "+DiemLy);
            Console.WriteLine("Điểm Hoá: "+DiemHoa);
            Console.WriteLine("Điểm Trung Bình: "+DiemTrungBinh);
            Console.WriteLine("Học Lực: "+HocLuc);
            Console.WriteLine("----------------------------------");
        }
    }
   
}
