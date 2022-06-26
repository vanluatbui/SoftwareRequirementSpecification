using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class Model_Config
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<UserModel, AspNetUser>();
            cfg.CreateMap<KhoaHocModel, KhoaHoc>();
            cfg.CreateMap<LopModel, Lop>();
            cfg.CreateMap<Lop_HocSinhModel, Lop_HocSinh>();
            cfg.CreateMap<MonHocModel, MonHoc>();
            cfg.CreateMap<Lop_MonHocModel, Lop_MonHoc>();
            cfg.CreateMap<ThoiKhoaBieuModel, ThoiKhoaBieu>();
            cfg.CreateMap<HinhThuc_Thi_KiemTraModel, HinhThuc_Thi_KiemTra>();
            cfg.CreateMap<Lop_Thi_KiemTraModel, Lop_Thi_KiemTra>();
            cfg.CreateMap<Diem_HocSinhModel, Diem_HocSinh>();
        }
    }
}
