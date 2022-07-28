using System;

namespace VD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nhanvien1 = new NhanVien();
            nhanvien1.MaNV = "M01";
            nhanvien1.TenNV = "Nguyen Viet Hoang";
            nhanvien1.Luong1gio = 3;
            nhanvien1.Sogiolam = 9;

            NhanVien nhanVien2 = new NhanVien();
            nhanVien2.Nhap("M02", "B", 2, 8);

            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
              nhanvien1.MaNV, nhanvien1.TenNV,
              nhanvien1.Luong1gio, nhanvien1.Sogiolam,
              nhanvien1.tinhLuong());

            Console.WriteLine(nhanVien2.Xuat());
            Console.ReadLine();
        }
    }
}
