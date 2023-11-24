using System.Text;


namespace QuanLySinhVien
{
    

    class Program
    {
        static List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public int soLuongSinhVien()
        {
            int soLuongSinhVien = 0;
            if (danhSachSinhVien != null)
            {
                soLuongSinhVien = danhSachSinhVien.Count;
            }
            return soLuongSinhVien;
        }
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("-------------------Menu-----------------");
                Console.WriteLine("1. Thêm sinh viên.");
                Console.WriteLine("2. Cập nhật thông tin sinh viên bởi ID.");
                Console.WriteLine("3. Xóa sinh viên bởi ID.");
                Console.WriteLine("4. Tìm kiếm sinh viên theo tên.");
                Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung bình (GPA).");
                Console.WriteLine("6. Sắp xếp sinh viên theo tên.");
                Console.WriteLine("7. Sắp xếp sinh viên theo ID.");
                Console.WriteLine("8. Hiển thị danh sách sinh viên.");
                Console.WriteLine("9. Thoát");
                Console.Write("Nhập chức năng: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        CapNhat();
                        break;
                    case 3:
                        Xoa();
                        break;
                    case 4:
                        TimKiemTheoTen();
                        break;
                    case 5:
                        SapXepTheoGPA();
                        break;
                    case 6:
                        SapXepTheoTen();
                        break;
                    case 7:
                        SapXepTheoID();
                        break;
                    case 8:
                        HienThiDanhSach();
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ sinh vui lòng nhập lại");
                        break;

                }
                Console.WriteLine();
            } while (chon != 0);

        }
        static void ThemSinhVien()
        {
            Console.WriteLine("-------------------THÊM SINH VIÊN-----------------");
            Console.Write("Nhập Tên Sinh Viên:");
            string ten = Console.ReadLine();
            Console.Write("Nhập Giới Tính: ");
            string gioiTinh = Console.ReadLine();
            Console.Write("nNhập Tuổi:");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Toán:");
            double diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Lý:");
            double diemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Hoá:");
            double diemHoa = double.Parse(Console.ReadLine());
            SinhVien sinhVien = new SinhVien(ten, gioiTinh, tuoi, diemToan, diemLy, diemHoa);
            danhSachSinhVien.Add(sinhVien);
            Console.WriteLine("Thêm Sinh Viên Thành Công");
            Console.WriteLine("---------------------------");

        }
        
        static void CapNhat()
        {
            SinhVien sv = TimSinhVien();

            if (sv != null)
            {

                Console.WriteLine("-------------------CẬP NHẬP SINH VIÊN-----------------");
                Console.Write("Nhập Tên Sinh Viên:");
                sv.Ten = Console.ReadLine();
                Console.Write("Nhập Giới Tính: ");
                sv.GioiTinh = Console.ReadLine();
                Console.Write("nNhập Tuổi:");
                sv.Tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhập Điểm Toán:");
                sv.DiemToan = double.Parse(Console.ReadLine());
                Console.Write("Nhập Điểm Lý:");
                sv.DiemLy = double.Parse(Console.ReadLine());
                Console.Write("Nhập Điểm Hoá:");
                sv.DiemHoa = double.Parse(Console.ReadLine());
                sv.DiemTrungBinh = (sv.DiemToan + sv.DiemLy + sv.DiemHoa) / 3;
                sv.HocLuc = sv.TinhHocLuc(sv.DiemTrungBinh);
                Console.WriteLine("Cập Nhật Sinh Viên Thành Công");
                Console.WriteLine("---------------------------");

            }
            else
            {
                Console.WriteLine("Không tìm thấy ID Sinh Viên Cần cập nhật");
                Console.WriteLine("---------------------------");
            }
        }
        static void Xoa()

        {
            Console.WriteLine("-------------------XOÁ SINH VIÊN-----------------");
            SinhVien sv = TimSinhVien();

            if (sv != null)
            {

                danhSachSinhVien.Remove(sv);
            }
            Console.WriteLine("Xoá thành công!");

        }
        static SinhVien TimSinhVien()
        {
            Console.Write("Nhập ID Sinh Viên Muốn Tìm: ");
            int id = int.Parse(Console.ReadLine());
            SinhVien sv = null;
            if (danhSachSinhVien != null && danhSachSinhVien.Count > 0)
            {
                foreach (SinhVien sinhVien in danhSachSinhVien)
                {
                    if (sinhVien.Id == id)
                    {
                        sv = sinhVien;
                    }
                }
            }
            return sv;

        }
        static void TimKiemTheoTen()
        {
            SinhVien timkiem = TimKiemTen();
            if(timkiem != null)
            {
                timkiem.HienThiSinhVien();
            }
        }
        static SinhVien TimKiemTen()
        {

            Console.Write("Nhập Tên Sinh Viên Muốn Tìm: ");
            string name =Console.ReadLine();
            SinhVien sv = null;
            if (danhSachSinhVien != null && danhSachSinhVien.Count > 0)
            {
                foreach (SinhVien sinhVien in danhSachSinhVien)
                {
                    if (sinhVien.Ten.Contains(name))
                    {
                        sv = sinhVien;
                    }
                }
            }
            return sv;
        }
        static void SapXepTheoGPA()
        {
           
            Console.WriteLine("-------------------sẮP XẾP THEO GPA-----------------");
            danhSachSinhVien.Sort((sv1,sv2)=>sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh));
            Console.WriteLine("Sắp xếp thành công !");
            Console.WriteLine("----------------------");

        }
        static void SapXepTheoTen()
        {
            Console.WriteLine("-------------------sẮP XẾP THEO TÊN-----------------");
            danhSachSinhVien.Sort((sv1, sv2) => sv1.Ten.CompareTo(sv2.Ten));
            Console.WriteLine("Sắp xếp thành công !");
            Console.WriteLine("----------------------");
        }
        static void SapXepTheoID()
        {
            Console.WriteLine("-------------------sẮP XẾP THEO ID-----------------");

            danhSachSinhVien.Sort((sv1, sv2) => sv1.Id.CompareTo(sv2.Id));
            Console.WriteLine("Sắp xếp thành công !");
            Console.WriteLine("----------------------");
        }
       static void HienThiDanhSach()
        {
            Console.WriteLine("--------------------DANH SÁCH SINH VIÊN---------------------");
            if (danhSachSinhVien.Count > 0)
            {
                for (int i = 0; i < danhSachSinhVien.Count; i++)
                {
                    danhSachSinhVien[i].HienThiSinhVien();
                }
            }
            else
            {
                Console.WriteLine("Danh sách sinh viên rỗng");
            }
        }
        
       
    }
}

    

