
using System;
using System.Collections.Generic;
using WinFormsApp3.Data.DAL;
using WinFormsApp3.Data.Etinity;

namespace WinFormsApp3.BUL
{
    internal class LopHocBUL
    {
        private LopDAL ld;

        public LopHocBUL()
        {
            ld = new LopDAL();
        }

        // Lấy danh sách lớp học
        public List<LopHoc> GetAllLopHocs()
        {
            try
            {
                return ld.GetAllLopHocs();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Lỗi khi lấy danh sách lớp học.", ex);
            }
        }

        // Thêm lớp học
        public void AddLopHoc(LopHoc lopHoc)
        {
            try
            {
                if (lopHoc == null)
                    throw new ArgumentNullException(nameof(lopHoc));

                ld.AddLopHoc(lopHoc);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm lớp học.", ex);
            }
        }

        // Cập nhật lớp học
        public void UpdateLopHoc(LopHoc lopHoc)
        {
            try
            {
                if (lopHoc == null)
                    throw new ArgumentNullException(nameof(lopHoc));

                ld.UpdateLopHoc(lopHoc);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Lỗi khi cập nhật lớp học.", ex);
            }
        }

        // Xóa lớp học
        public bool DeleteLopHoc(string maLop)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maLop))
                    throw new ArgumentException(
                        "Mã lớp không được để trống.", nameof(maLop));

                return ld.DeleteLopHoc(maLop);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa lớp học.", ex);
            }
        }

        // Tìm lớp học theo mã lớp
        public LopHoc GetLopHocById(string maLop)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maLop))
                    throw new ArgumentException(
                        "Mã lớp không được để trống.", nameof(maLop));

                return ld.GetLopHocById(maLop);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm lớp học.", ex);
            }
        }
    }
}
