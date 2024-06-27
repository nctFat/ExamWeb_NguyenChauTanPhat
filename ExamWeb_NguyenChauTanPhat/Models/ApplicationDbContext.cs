using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenChauTanPhat.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> ops) : base(ops)
        {

        }
        public DbSet<Phim> Phims { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Phim>().HasData(
                  new Phim { Id = 1, TuaDe = "Tro tàn rực rỡ", TrongNuoc = true, GiaVe = 12000, ThoiLuong = 10 },
                  new Phim { Id = 2, TuaDe = "MAI", TrongNuoc = false, GiaVe = 12000, ThoiLuong = 15 },
                  new Phim { Id = 3, TuaDe = "Lật mặt", TrongNuoc = true, GiaVe = 12000, ThoiLuong = 10 },
                  new Phim { Id = 4, TuaDe = "Mắt biếc", TrongNuoc = false, GiaVe = 12000, ThoiLuong = 15 },
                  new Phim { Id = 5, TuaDe = "Nhắm mắt thấy mùa hè", TrongNuoc = true, GiaVe = 12000, ThoiLuong = 10 },
                  new Phim { Id = 6, TuaDe = "Hùng long phong bá", TrongNuoc = true, GiaVe = 12000, ThoiLuong = 15 }
                );

        }
    }
}
