using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class HINHCHUNHAT: HINH
    {
        private int canhA { get; set; }
        private int canhB { get; set; }

        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            Console.WriteLine("Nhap canh A: ");
            this.canhA = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh B: ");
            this.canhB = int.Parse(Console.ReadLine());
        }

        public override double tinhChuVi()
        {
            return 2 * (this.canhA + this.canhB);
        }

        public override double tinhDienTich()
        {
            return this.canhA * this.canhB;
        }
    }
}
