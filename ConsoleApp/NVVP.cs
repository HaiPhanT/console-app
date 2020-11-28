using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp
{
    class NVVP
    {
        private int maNV;
        private string ten;
        private string diaChi;
        private int heSoLuong;
        private int phuCap;

        public void Nhap()
        {
            Console.WriteLine("Nhap ma nv: ");
            this.maNV = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten nv: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi nv: ");
            this.diaChi = Console.ReadLine();
            Console.WriteLine("Nhap he so luong: ");
            this.heSoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap nv: ");
            this.phuCap = int.Parse(Console.ReadLine());
        }

        public int TinhLuong()
        {
            return this.heSoLuong*100 + this.phuCap;
        }
        }

}
