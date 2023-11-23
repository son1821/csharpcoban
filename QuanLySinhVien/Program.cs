using System.Text;


namespace QuanLySinhVien
{

    class Program
    {
        public static SinhVien[] danhSachSinhVien = new SinhVien[100];
        public static int soLuongSinhVien = 0;
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
                        TimKiemBangTen();
                        break;
                    case 5:
                        SapXepTheoGPA();
                        break;
                    case 6:
                        SapXepTheoTen();
                        break;
                    case 8:
                        HienThiDanhSach();
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ sinh vui lòng nhập lại");
                        break;
                       
                }
                Console.WriteLine();
            } while (chon != 0 );
            
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
            danhSachSinhVien[soLuongSinhVien]=sinhVien;
            soLuongSinhVien++;
            Console.WriteLine("Thêm Sinh Viên Thành Công");
            Console.WriteLine("---------------------------");
        }
        static int TimViTri(int id)
        {
            for(int i = 0; i < soLuongSinhVien; i++)
            {
                if(danhSachSinhVien[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
        static void CapNhat()
        {
            Console.Write("Nhập ID Sinh Viên Muốn Cập Nhật: ");
            int id = int.Parse(Console.ReadLine());
            int vitri = TimViTri(id);
            if(vitri != -1)
            {
               SinhVien sinhVien = danhSachSinhVien[vitri];
                Console.WriteLine("-------------------CẬP NHẬP SINH VIÊN-----------------");
                Console.Write("Nhập Tên Sinh Viên:");
                sinhVien.Ten = Console.ReadLine();
                Console.Write("Nhập Giới Tính: ");
                sinhVien.GioiTinh = Console.ReadLine();
                Console.Write("nNhập Tuổi:");
                sinhVien.Tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhập Điểm Toán:");
                sinhVien.DiemToan = double.Parse(Console.ReadLine());
                Console.Write("Nhập Điểm Lý:");
                sinhVien.DiemLy = double.Parse(Console.ReadLine());
                Console.Write("Nhập Điểm Hoá:");
                sinhVien.DiemHoa = double.Parse(Console.ReadLine());
                sinhVien.DiemTrungBinh = (sinhVien.DiemToan + sinhVien.DiemLy + sinhVien.DiemHoa) / 3;
                sinhVien.HocLuc = sinhVien.TinhHocLuc(sinhVien.DiemTrungBinh);
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
            Console.Write("Nhập ID Cần Xoá:  ");
            int id = int.Parse(Console.ReadLine());
            int vitri = TimViTri(id);
            if(vitri != -1)
            {
                for(int i = vitri;i< soLuongSinhVien-1; i++)
                {
                    danhSachSinhVien[i] = danhSachSinhVien[i + 1];
                }
                danhSachSinhVien[soLuongSinhVien - 1] = null;
                soLuongSinhVien--;
                Console.WriteLine("Xoá thành công!");
            }
            else
            {
                Console.WriteLine("Bạn đã nhập sai ID sinh viên");
            }
        }
        static void TimKiemBangTen()
        {
            Console.WriteLine("-------------------TÌM KIẾM SINH VIÊN THEO TÊN-----------------");
            Console.Write("Nhập tên sinh viên cần tìm kiếm:");
            string tenTimKiem = Console.ReadLine();
            for(int i = 0; i < soLuongSinhVien; i++)
            {
                if(tenTimKiem == danhSachSinhVien[i].Ten)
                {
                    Console.WriteLine("Tìm kiếm thành công!");
                    danhSachSinhVien[i].HienThiSinhVien();
                    
                }
                else
                {
                    Console.WriteLine("Tên bạn nhâp không đúng.");
                }
            }
            
        }
        static void SapXepTheoGPA()
        {
            Console.WriteLine("-------------------sẮP XẾP THEO GPA-----------------");
            for(int i = 0; i <  soLuongSinhVien-1; i++)
            {
                for(int j = i + 1; j < soLuongSinhVien; j++)
                {
                    if (danhSachSinhVien[i].DiemTrungBinh < danhSachSinhVien[j].DiemTrungBinh)
                    {
                        
                        SinhVien sv = danhSachSinhVien[i];
                        danhSachSinhVien[i] = danhSachSinhVien[j];
                        danhSachSinhVien[j] = sv;
                        danhSachSinhVien[i].HienThiSinhVien();
                    }
                }
            }
            Console.WriteLine("Sắp xếp thành công !");
            Console.WriteLine("----------------------");

        }
        static void SapXepTheoTen()
        {
            Console.WriteLine("-------------------sẮP XẾP THEO TÊN-----------------");
            for (int i = 0; i < soLuongSinhVien; i++)
            {
                for(int j = i + 1; j < soLuongSinhVien; j++)
                {
                    char ChuCaiDauI = danhSachSinhVien[i].Ten[0];
                    char ChuCaiDauJ = danhSachSinhVien[j].Ten[0];
                    if(ChuCaiDauI > ChuCaiDauJ)
                    {
                        SinhVien sv = danhSachSinhVien[i];
                        danhSachSinhVien[i] = danhSachSinhVien[j];
                        danhSachSinhVien[j] = sv;
                        
                    }
                }
            }
            Console.WriteLine("Sắp xếp thành công !");
            Console.WriteLine("----------------------");
        }
        static void SapXepTheoID()
        {
            Console.WriteLine("-------------------sẮP XẾP THEO ID-----------------");
            for (int i = 0; i < soLuongSinhVien; i++)
            {
                for (int j = i+1; j < soLuongSinhVien; j++)
                {
                    if (danhSachSinhVien[i].Id < danhSachSinhVien[j].Id)
                    {
                        SinhVien sv = danhSachSinhVien[i];
                        danhSachSinhVien[i] = danhSachSinhVien[j];
                        danhSachSinhVien[j] = sv;
                    }
                }
            }
            Console.WriteLine("Sắp xếp thành công !");
            Console.WriteLine("----------------------");
        }
       static void HienThiDanhSach()
        {
            Console.WriteLine("--------------------DANH SÁCH SINH VIÊN---------------------");
            if (soLuongSinhVien > 0)
            {
                for (int i = 0; i < soLuongSinhVien; i++)
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

