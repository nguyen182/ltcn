
using MySql.Data.MySqlClient;
using QuanLySinhVien.Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using WinFormsApp3.Data.Etinity;

namespace WinFormsApp3.Data.DAL
{
    public class LopHocDAO
    {
        private readonly DataHelper dataHelper = new DataHelper();

        private LopHoc MapLopHoc(DataRow dr)
        {
            return new LopHoc
            {
                MaLop = Convert.ToString(dr["MaLop"]),
                TenLop = Convert.ToString(dr["TenLop"])
            };
        }

        // Lấy tất cả lớp học
        public List<LopHoc> GetAllLopHoc()
        {
            try
            {
                List<LopHoc> danhSach = new List<LopHoc>();

                DataTable dt = dataHelper.GetDataTable(
                    "SELECT MaLop, TenLop FROM LopHoc");

                foreach (DataRow dr in dt.Rows)
                {
                    danhSach.Add(MapLopHoc(dr));
                }

                return danhSach;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách lớp học.", ex);
            }
        }

        // Tìm lớp học theo mã lớp
        public LopHoc GetLopHocByMaLop(string maLop)
        {
            try
            {
                DataTable dt = dataHelper.GetDataTable(
                    "SELECT MaLop, TenLop FROM LopHoc WHERE MaLop = @MaLop",
                    new MySqlParameter("@MaLop", MySqlDbType.VarChar)
                    {
                        Value = maLop
                    });

                if (dt.Rows.Count == 0)
                    return null;

                return MapLopHoc(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm lớp học.", ex);
            }
        }

        // Thêm lớp học
        public void AddLopHoc(LopHoc lop)
        {
            try
            {
                string sql =
                    "INSERT INTO LopHoc (MaLop, TenLop) " +
                    "VALUES (@MaLop, @TenLop)";

                dataHelper.ExecuteNonQuery(
                    sql,
                    new MySqlParameter("@MaLop", MySqlDbType.VarChar)
                    {
                        Value = lop.MaLop
                    },
                    new MySqlParameter("@TenLop", MySqlDbType.VarChar)
                    {
                        Value = lop.TenLop
                    });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm lớp học.", ex);
            }
        }

        // Cập nhật lớp học
        public void UpdateLopHoc(LopHoc lop)
        {
            try
            {
                string sql =
                    "UPDATE LopHoc SET TenLop = @TenLop " +
                    "WHERE MaLop = @MaLop";

                dataHelper.ExecuteNonQuery(
                    sql,
                    new MySqlParameter("@MaLop", MySqlDbType.VarChar)
                    {
                        Value = lop.MaLop
                    },
                    new MySqlParameter("@TenLop", MySqlDbType.VarChar)
                    {
                        Value = lop.TenLop
                    });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật lớp học.", ex);
            }
        }

        // Xóa lớp học
        public void DeleteLopHoc(string maLop)
        {
            try
            {
                string sql =
                    "DELETE FROM LopHoc WHERE MaLop = @MaLop";

                dataHelper.ExecuteNonQuery(
                    sql,
                    new MySqlParameter("@MaLop", MySqlDbType.VarChar)
                    {
                        Value = maLop
                    });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa lớp học.", ex);
            }
        }
    }
}
