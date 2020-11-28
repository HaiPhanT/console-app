using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class CTY
    {
        private string tenCty { get; set; }
        private List<NVVP> dsNVVP;
        private List<NVSX> dsNVSX;

        public CTY()
        {
            dsNVVP = new List<NVVP>();
            dsNVSX = new List<NVSX>();
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ten cty: ");
            this.tenCty = Console.ReadLine();
            Console.WriteLine("Nhap so luong nvvp: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                NVVP nvvp = new NVVP();
                nvvp.Nhap();
                dsNVVP.Add(nvvp);
            }
            Console.WriteLine("Nhap so luong nvsx: ");
            int s = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                NVSX nvsx = new NVSX();
                nvsx.Nhap();
                dsNVSX.Add(nvsx);
            }
        }

        public double TinhTongLuong()
        {
            double tongLuong = 0;
            foreach(NVVP nvvp in this.dsNVVP)
            {
                tongLuong += nvvp.TinhLuong();
            }
            foreach (NVSX nvsx in this.dsNVSX)
            {
                tongLuong += nvsx.TinhLuong();
            }
            return tongLuong;
        }

    }
}
