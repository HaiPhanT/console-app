using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class HINHTRON: HINH
    {
        private int banKinh { get; set; }

        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            Console.WriteLine("Nhap ban kinh: ");
            this.banKinh = int.Parse(Console.ReadLine());
        }

        public override double tinhChuVi()
        {
            return Math.PI * this.banKinh;
        }

        public override double tinhDienTich()
        {
            return Math.PI * this.banKinh * this.banKinh;
        }
    }
}
