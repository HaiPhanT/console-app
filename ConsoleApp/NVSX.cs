using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp
{
    class NVSX
    {
        private int maNV;
        private string ten;
        private string diaChi;
        private int soSP;

        public void Nhap()
        {
            Console.WriteLine("Nhap ma nv: ");
            this.maNV = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten nv: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi nv: ");
            this.diaChi = Console.ReadLine();
            Console.WriteLine("Nhap so san pham: ");
            this.soSP = int.Parse(Console.ReadLine());
        }

        public int TinhLuong()
        {
            return this.soSP * 2;
        }
        }

}
