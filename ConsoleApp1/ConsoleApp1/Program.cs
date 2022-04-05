using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct SinhVien
        {
            public string HoTen_263;
            public string MaSV_263;
            public string Lop_263;
            public double Toan_263;
            public double Ly_263;
            public double Hoa_263;
        }

        enum DiemMonHoc
        {
            DiemToan_263 = 8,
            DiemLy_263 = 9,
            DiemHoa_263 = 7,
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write("\nNhap ho ten sinh vien: ");
            SV.HoTen_263 = Console.ReadLine();
            Console.Write("\nNhap ma sinh vien: ");
            SV.MaSV_263 = Console.ReadLine();
            Console.Write("\nNhap lop: ");
            SV.Lop_263 = Console.ReadLine();

            Console.Write("\nNhap diem toan: ");
            SV.Toan_263 = double.Parse(Console.ReadLine());
            Console.Write("\nNhap diem ly: ");
            SV.Ly_263 = double.Parse(Console.ReadLine());
            Console.Write("\nNhap diem hoa: ");
            SV.Hoa_263 = double.Parse(Console.ReadLine());


            if (SV.Toan_263 == (double)DiemMonHoc.DiemToan_263)
                Console.Write("\n Diem toan: " + SV.Toan_263);
            else
                Console.Write("\nDiem toan khong dung! ");

            if (SV.Ly_263 == (double)DiemMonHoc.DiemLy_263)
                Console.Write("\n Diem ly: " + SV.Ly_263);
            else
                Console.Write("\nDiem ly khong dung! ");

            if (SV.Hoa_263 == (double)DiemMonHoc.DiemHoa_263)
                Console.Write("\n Diem hoa: " + SV.Hoa_263);
            else
                Console.Write("\nDiem hoa khong dung! ");
        }


        static void InThongTinSinhVien(SinhVien SV)
        {
            Console.Write("\n Ho ten sinh vien: " + SV.HoTen_263);
            Console.Write("\n Ma sinh vien: " + SV.MaSV_263);
            Console.Write("\n Lop: " + SV.Lop_263);
            Console.Write("\n Diem toan: " + SV.Toan_263);
            Console.Write("\n Diem ly: " + SV.Ly_263);
            Console.Write("\n Diem hoa: " + SV.Hoa_263);
        }

        //static float DiemTB(SinhVien SV)
        //{

        //}

        static void Main(string[] args)
        {
            SinhVien SV1_263 = new SinhVien();

            string[] DSSV_263 = { "BuiChiThong", "1911505310263", "19T2", " 8 ", " 9 ", " 10 " };
            foreach (string ThongTin_263 in DSSV_263)
            {
                Console.Write("\n Thong tin: " + ThongTin_263);
                Console.WriteLine("");
            }

            NhapThongTinSinhVien(out SV1_263);
            Console.Write("\nThong tin cua sinh vien: ");
            InThongTinSinhVien(SV1_263);

            Console.ReadKey();
        }
    }
}
