using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOP_PHAN_SO p1, p2;
            //p1 = new LOP_PHAN_SO();
            //p2 = new LOP_PHAN_SO();
            //p1.NhapPhanSo("Nhap phan so a: ");
            //p2.NhapPhanSo("Nhap phan so a: ");
            //LOP_PHAN_SO kq = new LOP_PHAN_SO();
            //kq = p1.CongPhanSo(p2);
            //string Chuoi = "kq la: " + kq.XuatPhanSo();

            //Console.WriteLine(Chuoi);

            //    DIEM a, b;
            //    a = new DIEM();
            //    b = new DIEM();

            //    a.KhoiTaoDiem("Nhap toa do diem a: ");
            //    b.KhoiTaoDiem("Nhap toa do diem b: ");

            //    double kq = a.TinhKhoangCach(b);

            //    Console.WriteLine("kq la: " + kq);

            CTY x = new CTY();
            x.Nhap();
            Console.WriteLine(x.TinhTongLuong());
        }
    }
}
