using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WinFormsApp3.Data.Etinity
{
    public class LopHoc
    {
        [Required]
        [RegularExpression(@"^CSE[0-9]{4}$", ErrorMessage = "Mã lớp phải có định dạng: CSE followed by 4 digits.")]
        public string MaLop { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Tên lớp phải có từ 5 đến 30 ký tự!")]
        public string TenLop { get; set; }

        public List<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            // Custom validation logic for MaLop
            if (!string.IsNullOrEmpty(MaLop) && !System.Text.RegularExpressions.Regex.IsMatch(MaLop, @"^CSE[0-9]{4}$"))
            {
                results.Add(new ValidationResult("Mã lớp phải có định dạng: CSE followed by 4 digits.", new[] { nameof(MaLop) }));
            }

            // Custom validation logic for TenLop
            if (!string.IsNullOrEmpty(TenLop) && (TenLop.Length < 5 || TenLop.Length > 30))
            {
                results.Add(new ValidationResult("Tên lớp phải có từ 5 đến 30 ký tự!", new[] { nameof(TenLop) }));
            }

            return results;
        }
    }
}