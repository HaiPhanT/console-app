using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class MATPHANG
    {
        public List<HINH> dsHinh;

        public MATPHANG()
        {
            this.dsHinh = new List<HINH>();
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap so luong hinh: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap loai hinh(1.HCN/2.HV/3.HT): ");
                int l = int.Parse(Console.ReadLine());
                HINH h;
                if(l == 1)
                {
                    h = new HINHCHUNHAT();
                }
                if(l == 2)
                {
                    h = new HINHVUONG();
                }
                if (l == 3)
                {
                    h = new HINHTRON();
                }
                else
                {
                    h = new HINH();
                }
                h.Nhap("Nhap kich thuoc hinh: ");
                h.tinhChuVi();
                h.tinhDienTich();
                this.dsHinh.Add(h);
            }
        }
    }
}
