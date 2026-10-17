
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace QuanLySinhVien.Data.DAL
{
    public class DataHelper
    {
        private readonly string connectionString;

        public DataHelper()
        {
            connectionString =
                "Server=127.0.0.1;Port=3306;Database=QuanLySinhVien;Uid=root;Pwd=Nguyenle1182@;";
        }

        // Kiểm tra kết nối MySQL
        public void OpenConnection()
        {
            try
            {
                using (MySqlConnection con =
                       new MySqlConnection(connectionString))
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Không thể kết nối cơ sở dữ liệu MySQL.", ex);
            }
        }

        // Kết nối được tự đóng bằng using
        public void CloseConnection()
        {
            // Không cần xử lý thêm.
        }

        // Thêm, sửa, xóa dữ liệu
        public int ExecuteNonQuery(
            string sql,
            params MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection con =
                       new MySqlConnection(connectionString))
                using (MySqlCommand cmd =
                       new MySqlCommand(sql, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Lỗi khi thêm, sửa hoặc xóa dữ liệu.", ex);
            }
        }

        // Đọc dữ liệu bằng DataReader
        public MySqlDataReader ExcuteReader(string sqlSelect)
        {
            MySqlConnection con =
                new MySqlConnection(connectionString);

            try
            {
                con.Open();

                MySqlCommand command =
                    new MySqlCommand(sqlSelect, con);

                return command.ExecuteReader(
                    CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                con.Dispose();

                throw new Exception(
                    "Lỗi khi đọc dữ liệu.", ex);
            }
        }

        // Truy vấn dữ liệu và trả về DataTable
        public DataTable GetDataTable(
            string sqlSelect,
            params MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection con =
                       new MySqlConnection(connectionString))
                using (MySqlCommand command =
                       new MySqlCommand(sqlSelect, con))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter =
                           new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Lỗi khi truy vấn dữ liệu.", ex);
            }
        }
    }
}
