using E_learning.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_learning
{
    public class ApplicationDbContext : IdentityDbContext<AspNetUser>
    {
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Lop_HocSinh> Lop_HocSinhs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<Lop_MonHoc> Lop_MonHocs { get; set; }
        public DbSet<ThoiKhoaBieu> ThoiKhoaBieus { get; set; }
        public DbSet<HinhThuc_Thi_KiemTra> HinhThuc_Thi_KiemTras { get; set; }
        public DbSet<Lop_Thi_KiemTra> Lop_Thi_KiemTras { get; set; }
        public DbSet<Diem_HocSinh> Diem_HocSinhs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override async void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
