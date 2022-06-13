using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class LopConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ LopModel => Lop
            cfg.CreateMap<LopModel, Lop>();

            // config chuyển đổi từ Lop => LopModel
            cfg.CreateMap<Lop, LopModel>();
        }
    }
}
