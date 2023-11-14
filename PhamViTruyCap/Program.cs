using System;
namespace PhamViTruyCap
{
    class SinhVien
    {
        private string MSV;// Khởi tạo thuộc tính
        private double DiemLy;
        private double DiemToan;
        public double DiemLy1
        {
            get { return DiemLy; }
            set { DiemLy = value; }
        }
        public string MSV1
        {
            get { return MSV; }
            set { MSV = value; }
        }
        public double DiemToan1
        {
            get { return DiemToan; }
            set { DiemToan = value; }

        }
        public void Run() // Khởi tạo phương thức
        {
            Console.WriteLine("MSV:{0}, Diem Ly: {1}, Diem Toan: {2} ",MSV, DiemLy,DiemToan);
        }
    }
    internal class Program
    {
        
         static void Main(string[] args)
        {
              SinhVien SV1 = new SinhVien();
            SV1.DiemLy1 = 5;
            SV1.DiemToan1 = 10;
            SV1.MSV1 = "1213434";
            SV1.Run();
            Console.ReadKey();
        }
      

    }
}

