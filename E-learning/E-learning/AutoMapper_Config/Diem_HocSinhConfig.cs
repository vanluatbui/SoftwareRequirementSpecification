using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class Diem_HocSinhConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ Diem_HocSinhModel => Diem_HocSinh
            cfg.CreateMap<Diem_HocSinhModel, Diem_HocSinh>();

            // config chuyển đổi từ Diem_HocSinh => Diem_HocSinhModel
            cfg.CreateMap<Diem_HocSinh, Diem_HocSinhModel>();
        }
    }
}
