using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD1
{
    class NhanVien
    {
        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _TenNV;
        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }
        private int _luong1gio;
        public int Luong1gio
        {
            get { return _luong1gio; }
            set { _luong1gio = value; }
        }
        private int _Sogiolam;
        public int Sogiolam
        {
            get { return _Sogiolam; }
            set { _Sogiolam = value; }
        }
        public void Nhap(string ma, string ten, int luonggio, int giolam)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.Luong1gio = luonggio;
            this.Sogiolam = giolam;
        }
        public int tinhLuong()
        {
            return this.Luong1gio*this.Sogiolam;
        }
        public string Xuat()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}",
              this.MaNV, this.TenNV, this.Luong1gio, this.Sogiolam,
              this.tinhLuong());
        }
    }
}
