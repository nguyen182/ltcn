
using System;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp3.Data.Etinity
{
    public class SinhVien
    {
        [Required]
        [RegularExpression(
            @"^SV[0-9]{8}$",
            ErrorMessage = "Mã sinh viên phải có định dạng SV theo sau bởi 8 chữ số.")]
        public string MaSV { get; set; } = string.Empty;

        [Required]
        [StringLength(
            50,
            MinimumLength = 2,
            ErrorMessage = "Họ tên phải có độ dài từ 2 đến 50 ký tự.")]
        public string HoTen { get; set; } = string.Empty;

        [Required]
        [RegularExpression(
            @"^(Nam|Nữ|Khác)$",
            ErrorMessage = "Giới tính phải là Nam, Nữ hoặc Khác.")]
        public string GioiTinh { get; set; } = string.Empty;

        [Required]
        public DateTime NgaySinh { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Định dạng email không hợp lệ.")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone(ErrorMessage = "Định dạng số điện thoại không hợp lệ.")]
        public string SoDienThoai { get; set; } = string.Empty;

        [Required]
        [RegularExpression(
            @"^CSE[0-9]{4}$",
            ErrorMessage = "Mã lớp phải có định dạng CSE theo sau bởi 4 chữ số.")]
        public string MaLop { get; set; } = string.Empty;

        [Required]
        public string TrangThai { get; set; } = string.Empty;

        [Required]
        [Range(
            0,
            10,
            ErrorMessage = "Điểm phải nằm trong khoảng từ 0 đến 10.")]
        public double Diem { get; set; }
    }
}
