using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class KhoaHocConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ KhoaHocModel => KhoaHoc
            cfg.CreateMap<KhoaHocModel, KhoaHoc>();

            // config chuyển đổi từ KhoaHoc => KhoaHocModel
            cfg.CreateMap<KhoaHoc, KhoaHocModel>();
        }
    }
}
