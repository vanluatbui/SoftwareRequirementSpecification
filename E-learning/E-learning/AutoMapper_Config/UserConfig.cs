using AutoMapper;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.AutoMapper_Config
{
    public class UserConfig
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ UserModel => User
            cfg.CreateMap<UserModel, AspNetUser>();

            // config chuyển đổi từ User => UserModel
            cfg.CreateMap<AspNetUser, UserModel>();
        }
    }
}
