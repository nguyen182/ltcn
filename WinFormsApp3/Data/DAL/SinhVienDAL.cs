
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using WinFormsApp3.Data.Etinity;

namespace QuanLySinhVien.Data.DAL
{
    public class SinhVienDAL
    {
        private readonly DataHelper dataHelper = new DataHelper();

        // Chuyển dữ liệu từ DataRow thành đối tượng SinhVien
        private SinhVien MapSinhVien(DataRow dr)
        {
            return new SinhVien
            {
                MaSV = Convert.ToString(dr["MaSV"]) ?? string.Empty,
                HoTen = Convert.ToString(dr["HoTen"]) ?? string.Empty,
                GioiTinh = Convert.ToString(dr["GioiTinh"]) ?? string.Empty,

                NgaySinh = dr["NgaySinh"] == DBNull.Value
                    ? DateTime.MinValue
                    : Convert.ToDateTime(dr["NgaySinh"]),

                SoDienThoai = dr["SoDienThoai"] == DBNull.Value
                    ? string.Empty
                    : Convert.ToString(dr["SoDienThoai"]) ?? string.Empty,

                MaLop = dr["MaLop"] == DBNull.Value
                    ? string.Empty
                    : Convert.ToString(dr["MaLop"]) ?? string.Empty,

                Diem = dr["Diem"] == DBNull.Value
                    ? 0
                    : Convert.ToDouble(dr["Diem"]),

                Email = dr["Email"] == DBNull.Value
                    ? string.Empty
                    : Convert.ToString(dr["Email"]) ?? string.Empty
            };
        }

        // Lấy toàn bộ sinh viên
        public List<SinhVien> GetAllSinhVien()
        {
            try
            {
                List<SinhVien> danhSach = new List<SinhVien>();

                DataTable dt = dataHelper.GetDataTable(
                    "SELECT MaSV, HoTen, GioiTinh, NgaySinh, " +
                    "SoDienThoai, MaLop, Diem, Email FROM SinhVien");

                foreach (DataRow dr in dt.Rows)
                {
                    danhSach.Add(MapSinhVien(dr));
                }

                return danhSach;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sinh viên.", ex);
            }
        }

        // Giữ tên phương thức cũ để tương thích với BUS
        public List<SinhVien> getAllSinhVien1()
        {
            return GetAllSinhVien();
        }

        public List<SinhVien> GetAllSinhVien1()
        {
            return GetAllSinhVien();
        }

        // Tìm sinh viên theo mã sinh viên
        public SinhVien GetSinhVienByMaSV(string maSV)
        {
            try
            {
                DataTable dt = dataHelper.GetDataTable(
                    "SELECT MaSV, HoTen, GioiTinh, NgaySinh, " +
                    "SoDienThoai, MaLop, Diem, Email " +
                    "FROM SinhVien WHERE MaSV = @MaSV",
                    new MySqlParameter("@MaSV", MySqlDbType.VarChar)
                    {
                        Value = maSV
                    });

                if (dt.Rows.Count == 0)
                    return null;

                return MapSinhVien(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm sinh viên.", ex);
            }
        }

        // Giữ tên phương thức cũ
        public SinhVien GetSinhVienById(string maSV)
        {
            return GetSinhVienByMaSV(maSV);
        }

        // Lấy danh sách sinh viên theo mã lớp
        public List<SinhVien> GetSinhViensByMaLop(string maLop)
        {
            try
            {
                List<SinhVien> danhSach = new List<SinhVien>();

                DataTable dt = dataHelper.GetDataTable(
                    "SELECT MaSV, HoTen, GioiTinh, NgaySinh, " +
                    "SoDienThoai, MaLop, Diem, Email " +
                    "FROM SinhVien WHERE MaLop = @MaLop",
                    new MySqlParameter("@MaLop", MySqlDbType.VarChar)
                    {
                        Value = maLop
                    });

                foreach (DataRow dr in dt.Rows)
                {
                    danhSach.Add(MapSinhVien(dr));
                }

                return danhSach;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Lỗi khi lấy danh sách sinh viên theo lớp.", ex);
            }
        }

        // Thêm sinh viên
        public void AddSinhVien(SinhVien sv)
        {
            try
            {
                if (sv == null)
                    throw new ArgumentNullException(nameof(sv));

                string sql =
                    "INSERT INTO SinhVien " +
                    "(MaSV, MaLop, HoTen, GioiTinh, NgaySinh, " +
                    "Diem, SoDienThoai, Email) " +
                    "VALUES (@MaSV, @MaLop, @HoTen, @GioiTinh, " +
                    "@NgaySinh, @Diem, @SoDienThoai, @Email)";

                dataHelper.ExecuteNonQuery(
                    sql,
                    new MySqlParameter("@MaSV", MySqlDbType.VarChar)
                    {
                        Value = sv.MaSV
                    },
                    new MySqlParameter("@MaLop", MySqlDbType.VarChar)
                    {
                        Value = (object)sv.MaLop ?? DBNull.Value
                    },
                    new MySqlParameter("@HoTen", MySqlDbType.VarChar)
                    {
                        Value = sv.HoTen
                    },
                    new MySqlParameter("@GioiTinh", MySqlDbType.VarChar)
                    {
                        Value = sv.GioiTinh
                    },
                    new MySqlParameter("@NgaySinh", MySqlDbType.Date)
                    {
                        Value = sv.NgaySinh.Date
                    },
                    new MySqlParameter("@Diem", MySqlDbType.Double)
                    {
                        Value = sv.Diem
                    },
                    new MySqlParameter("@SoDienThoai", MySqlDbType.VarChar)
                    {
                        Value = (object)sv.SoDienThoai ?? DBNull.Value
                    },
                    new MySqlParameter("@Email", MySqlDbType.VarChar)
                    {
                        Value = (object)sv.Email ?? DBNull.Value
                    });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sinh viên.", ex);
            }
        }

        // Cập nhật sinh viên
        public void UpdateSinhVien(SinhVien sv)
        {
            try
            {
                if (sv == null)
                    throw new ArgumentNullException(nameof(sv));

                string sql =
                    "UPDATE SinhVien SET " +
                    "HoTen = @HoTen, " +
                    "MaLop = @MaLop, " +
                    "GioiTinh = @GioiTinh, " +
                    "NgaySinh = @NgaySinh, " +
                    "Diem = @Diem, " +
                    "SoDienThoai = @SoDienThoai, " +
                    "Email = @Email " +
                    "WHERE MaSV = @MaSV";

                dataHelper.ExecuteNonQuery(
                    sql,
                    new MySqlParameter("@MaSV", MySqlDbType.VarChar)
                    {
                        Value = sv.MaSV
                    },
                    new MySqlParameter("@HoTen", MySqlDbType.VarChar)
                    {
                        Value = sv.HoTen
                    },
                    new MySqlParameter("@MaLop", MySqlDbType.VarChar)
                    {
                        Value = (object)sv.MaLop ?? DBNull.Value
                    },
                    new MySqlParameter("@GioiTinh", MySqlDbType.VarChar)
                    {
                        Value = sv.GioiTinh
                    },
                    new MySqlParameter("@NgaySinh", MySqlDbType.Date)
                    {
                        Value = sv.NgaySinh.Date
                    },
                    new MySqlParameter("@Diem", MySqlDbType.Double)
                    {
                        Value = sv.Diem
                    },
                    new MySqlParameter("@SoDienThoai", MySqlDbType.VarChar)
                    {
                        Value = (object)sv.SoDienThoai ?? DBNull.Value
                    },
                    new MySqlParameter("@Email", MySqlDbType.VarChar)
                    {
                        Value = (object)sv.Email ?? DBNull.Value
                    });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật sinh viên.", ex);
            }
        }

        // Xóa sinh viên
        public void DeleteSinhVien(string maSV)
        {
            try
            {
                string sql =
                    "DELETE FROM SinhVien WHERE MaSV = @MaSV";

                dataHelper.ExecuteNonQuery(
                    sql,
                    new MySqlParameter("@MaSV", MySqlDbType.VarChar)
                    {
                        Value = maSV
                    });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sinh viên.", ex);
            }
        }
    }
}
