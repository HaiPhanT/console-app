using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class LOP_PHAN_SO
    {
        public int TuSo;
        public int MauSo;

        public void NhapPhanSo(string GhiChu)
        {
            Console.WriteLine(GhiChu);
            Console.WriteLine("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }

        public LOP_PHAN_SO CongPhanSo(LOP_PHAN_SO b)
        {
            LOP_PHAN_SO kq = new LOP_PHAN_SO();
            kq.TuSo = TuSo * b.MauSo + MauSo * b.TuSo;
            kq.MauSo = MauSo * b.MauSo;
            return kq;
        }

        public string XuatPhanSo()
        {
            return $"{TuSo}/{MauSo}";
        }

    }
}
