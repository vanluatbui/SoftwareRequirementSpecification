using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class ThoiKhoaBieuConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ ThoiKhoaBieuModel => ThoiKhoaBieu
            cfg.CreateMap<ThoiKhoaBieuModel, ThoiKhoaBieu>();

            // config chuyển đổi từ ThoiKhoaBieu => ThoiKhoaBieuModel
            cfg.CreateMap<ThoiKhoaBieu, ThoiKhoaBieuModel>();
        }
    }
}
