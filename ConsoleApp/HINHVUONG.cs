using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class HINHVUONG: HINH
    {
        private int canh { get; set; }

        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            Console.WriteLine("Nhap canh: ");
            this.canh = int.Parse(Console.ReadLine());
        }

        public override double tinhChuVi()
        {
            return 4 * this.canh;
        }

        public override double tinhDienTich()
        {
            return this.canh * this.canh;
        }
    }
}
