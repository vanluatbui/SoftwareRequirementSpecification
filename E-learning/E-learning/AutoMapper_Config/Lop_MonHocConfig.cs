using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class Lop_MonHocConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ Lop_MonHocModel => Lop_MonHoc
            cfg.CreateMap<Lop_MonHocModel, Lop_MonHoc>();

            // config chuyển đổi từ Lop_MonHoc => Lop_MonHocModel
            cfg.CreateMap<Lop_MonHoc, Lop_MonHocModel>();
        }
    }
}
