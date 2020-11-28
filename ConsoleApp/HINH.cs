using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class HINH
    {
        public string Ten { get; set; }

        public virtual void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
        }

        public virtual double tinhChuVi()
        {
            return 0;
        }

        public virtual double tinhDienTich()
        {
            return 0;
        }
    }
}
