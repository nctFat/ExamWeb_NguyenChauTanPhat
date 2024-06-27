using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenChauTanPhat.Models
{
    public class Phim
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required(ErrorMessage = "Chưa nhập tiêu đề")]
        public string TuaDe { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Giá không hợp lệ")]
        public double GiaVe { get; set; }
        [Range(1, 1000, ErrorMessage = "Số lượng không hợp lệ")]
        public int ThoiLuong { get; set; }
        public bool TrongNuoc { get; set; }
    }
}
