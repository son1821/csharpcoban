namespace BaiTapLucGiao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sinhVien;
            NhapSinhVien(out  sinhVien);
            Console.WriteLine("Danh sach sinh vien:");
            HienThi(sinhVien,sinhVien.Length-1);
            Console.WriteLine("\nNhap thong tin sinh vien can them");
            string themnSinhVien = Console.ReadLine();
            Console.WriteLine("Danh sach sinh vien sau khi them:");
            ThemnSinhVien(sinhVien, themnSinhVien);
            HienThi(sinhVien, sinhVien.Length);
            int k;
            NhapK(out k);
            Console.WriteLine("\nNhap thong tin sinh vien can cap nhat:");
            string capNhatSinhVien = Console.ReadLine();
            Console.WriteLine("\nDanh sach sinh vien sau khi cap nhat:");
            CapNhat(sinhVien, k, capNhatSinhVien);
            HienThi(sinhVien, sinhVien.Length);
            int x;
            NhapX(out x);
            Console.WriteLine("\nDanh sach sinh vien sau khi xoa:");
            XoaSinhVien(sinhVien, x);
            HienThi(sinhVien, sinhVien.Length-1);
            Console.ReadLine();
        }

        private static void XoaSinhVien(string[] sinhVien, int x)
        {
            for (int i = x; i < sinhVien.Length-1; i++)
            {
                sinhVien[i] = sinhVien[i];
            }
        }

        private static void NhapX(out int x)
        {
            Console.Write("Moi ban nhap ID sinh vien can xoa: ");
            x=Convert.ToInt32(Console.ReadLine());
        }

        private static void CapNhat(string[] sinhVien, int k, string capNhatSinhVien)
        {
            for (int i = 0; i < sinhVien.Length; i++)
            {
                if(i==k && k < sinhVien.Length)
                {
                    sinhVien[i] = capNhatSinhVien;
                }
            }
        }

        private static void NhapK(out int k)
        {
            Console.Write("Moi ban nhap msv can cap nhat: ");
            k=Convert.ToInt32(Console.ReadLine());
        }

        private static void ThemnSinhVien(string[] sinhVien, string themnSinhVien)
        {
           for (int i = 0; i < sinhVien.Length; i++)
            {
                if (i == sinhVien.Length - 1)
                {
                    sinhVien[i] = themnSinhVien;
                }
            }
        }

        private static void HienThi(string[] sinhVien, int size)
        {
            for (int i = 0; i < size; i++) {
                Console.WriteLine($"MSV({i}): "+sinhVien[i]+" ");
            }

        }

        private static void NhapSinhVien(out string[] sinhVien)
        {
            Console.WriteLine("Nhap so sinh vien trong lop:");
            int soSinhVien = int.Parse(Console.ReadLine());
            if (soSinhVien > 0)
            {
                sinhVien = new string[soSinhVien];
                for(int i = 0; i < sinhVien.Length-1; i++)
                {
                    Console.Write($"Nhap thong tin sinh vien(Ten sinh vien, diem, toan, ly, hoa) MSV{i}:");
                    sinhVien[i] =Console.ReadLine();
                }

            }else
            {
                Console.WriteLine("Moi ban nhap lai!");
                 sinhVien = null;
            }
        }
    }
}
