using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class Lop_HocSinhConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ Lop_HocSinhModel => Lop_HocSinh
            cfg.CreateMap<Lop_HocSinhModel, Lop_HocSinh>();

            // config chuyển đổi từ Lop => Lop_HocSinhModel
            cfg.CreateMap<Lop_HocSinh, Lop_HocSinhModel>();
        }
    }
}
