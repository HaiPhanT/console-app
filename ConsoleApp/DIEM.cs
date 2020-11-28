using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class DIEM
    {
        private int x { get; set; }
        private int y { get; set; }

        public DIEM()
        {
            this.x = 0;
            this.y = 0;
        }

        public DIEM(int x, int y)
        {
            this.x = 0;
            this.y = 0;
        }

        public void KhoiTaoDiem(string GhiChu)
        {
            Console.WriteLine(GhiChu);
            Console.WriteLine("Nhap toa do X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do Y: ");
            y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(DIEM B)
        {
            return Math.Sqrt((x - B.x) * (x - B.x) + (y - B.y) * (y - B.y));
        }
    }
}
