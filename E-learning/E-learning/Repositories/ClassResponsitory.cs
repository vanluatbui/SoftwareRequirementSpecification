using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface IClassRepository : IRepository<Class>
    {
        List<ClassDTO> GetClasss();
        void InsertClass(ClassDTO newClass);

        void UpdateClass(ClassDTO newClass);

        void RemoveClass(string ID_Class);
    }

    public class ClassRespository : RepositoryBase<Class>, IClassRepository
    {
        IMapper mapper;
        public ClassRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<ClassDTO> GetClasss()
        {
            List<Class> listClass = _dbcontext.Classes.ToList();

            //Auto Mapper

            List<ClassDTO> listClassDTO = listClass.Select(emp => mapper.Map<Class, ClassDTO>(emp)).ToList();

            return listClassDTO;

        }

        public void InsertClass(ClassDTO newClass)
        {
            // Auto Mapper

            Class Class = mapper.Map<ClassDTO, Class>(newClass);

            _dbcontext.Classes.Add(Class);
            _dbcontext.SaveChanges();
        }

        public void UpdateClass(ClassDTO newClass)
        {
            Class Class = _dbcontext.Classes.First(p => p.ID_Class == newClass.ID_Class);

            _dbcontext.Entry(Class).CurrentValues.SetValues(newClass);

            _dbcontext.SaveChanges();
        }

        public void RemoveClass(string ID_Class)
        {
            Class Class = _dbcontext.Classes.First(p => p.ID_Class == ID_Class);

            _dbcontext.Classes.Remove(Class);

            _dbcontext.SaveChanges();
        }
    }
}
