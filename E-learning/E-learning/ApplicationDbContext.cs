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

            builder.Entity<Lop>().HasOne<AspNetUser>(P => P.GiaoVien).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Lop>().HasOne<KhoaHoc>(P => P.KhoaHoc).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Lop_HocSinh>().HasOne<Lop>(P => P.Lop).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Lop_HocSinh>().HasOne<AspNetUser>(P => P.HocSinh).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Lop_MonHoc>().HasOne<Lop>(P => P.Lop).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Lop_MonHoc>().HasOne<AspNetUser>(P => P.GiaoVien).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Lop_MonHoc>().HasOne<MonHoc>(P => P.MonHoc).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ThoiKhoaBieu>().HasOne<Lop>(P => P.Lop).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<ThoiKhoaBieu>().HasOne<MonHoc>(P => P.MonHoc).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Lop_Thi_KiemTra>().HasOne<Lop>(P => P.Lop).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Lop_Thi_KiemTra>().HasOne<HinhThuc_Thi_KiemTra>(P => P.HinhThuc).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Lop_Thi_KiemTra>().HasOne<MonHoc>(P => P.MonHoc).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Diem_HocSinh>().HasOne<AspNetUser>(P => P.HocSinh).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Diem_HocSinh>().HasOne<MonHoc>(P => P.MonHoc).WithMany().OnDelete(DeleteBehavior.NoAction);





        }
    }
}
