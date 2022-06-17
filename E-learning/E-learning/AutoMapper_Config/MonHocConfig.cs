using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class MonHocConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ MonHocModel => MonHoc
            cfg.CreateMap<MonHocModel, MonHoc>();

            // config chuyển đổi từ MonHoc => MonHocModel
            cfg.CreateMap<MonHoc, MonHocModel>();
        }
    }
}
