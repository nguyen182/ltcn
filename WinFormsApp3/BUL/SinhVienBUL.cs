using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using WinFormsApp3.Data.DAL;
using WinFormsApp3.Data.Etinity;

namespace WinFormsApp3.BUL
{
    internal class SinhVienBUL
    {
        SinhVienDAL svd;

        public SinhVienBUL()
        {
            svd = new SinhVienDAL();
        }

        public List<SinhVien> GetAllSinhViens()
        {
            return svd.GetAllSinhViens();
        }

        public void AddSinhVien(SinhVien sinhVien)
        {
            sinhVien.HoTen = sinhVien.HoTen.Trim().Replace("  ", " ");

            Regex regex = new Regex(@"^[a-zA-Z\s]+$");

            if (!regex.IsMatch(sinhVien.HoTen))
            {
                throw new Exception("Họ tên không hợp lệ.");
            }

            svd.AddSinhVien(sinhVien);
        }

        public void UpdateSinhVien(SinhVien sinhVien)
        {
            sinhVien.HoTen = sinhVien.HoTen.Trim().Replace("  ", " ");

            Regex regex = new Regex(@"^[a-zA-Z\s]+$");

            if (!regex.IsMatch(sinhVien.HoTen))
            {
                throw new Exception("Họ tên không hợp lệ.");
            }

            svd.UpdateSinhVien(sinhVien);
        }

        public bool DeleteSinhVien(string maSV)
        {
            return svd.DeleteSinhVien(maSV);
        }

        public SinhVien GetSinhVienById(string maSV)
        {
            return svd.GetSinhVienById(maSV);
        }
    }
}