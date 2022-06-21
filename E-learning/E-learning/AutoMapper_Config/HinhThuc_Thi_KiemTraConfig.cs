using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class HinhThuc_Thi_KiemTraConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ HinhThuc_Thi_KiemTModel => HinhThuc_Thi_KiemT
            cfg.CreateMap<HinhThuc_Thi_KiemTraModel, HinhThuc_Thi_KiemTra>();

            // config chuyển đổi từ HinhThuc_Thi_KiemTra => HinhThuc_Thi_KiemTraModel
            cfg.CreateMap<HinhThuc_Thi_KiemTra, HinhThuc_Thi_KiemTraModel>();
        }
    }
}
