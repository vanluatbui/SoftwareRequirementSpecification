using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class Lop_Thi_KiemTraConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ Lop_Thi_KiemTraModel => Lop_Thi_KiemTra
            cfg.CreateMap<Lop_Thi_KiemTraModel, Lop_Thi_KiemTra>();

            // config chuyển đổi từ Lop_Thi_KiemTra => Lop_Thi_KiemTraModel
            cfg.CreateMap<Lop_Thi_KiemTra, Lop_Thi_KiemTraModel>();
        }
    }
}
