
using AutoMapper;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.AutoMapper_Config
{
    public class Model_AutoMapper_Config
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
           cfg.CreateMap<LeaderShip, LeaderShipDTO>();
            cfg.CreateMap<LeaderShipDTO, LeaderShip>();

            cfg.CreateMap<Teacher, TeacherDTO>();
            cfg.CreateMap<TeacherDTO, Teacher>();

            cfg.CreateMap<Semester, SemesterDTO>();
            cfg.CreateMap<SemesterDTO, Semester>();

            cfg.CreateMap<Class, ClassDTO>();
            cfg.CreateMap<ClassDTO, Class>();

            cfg.CreateMap<Student, StudentDTO>();
            cfg.CreateMap<StudentDTO, Student>();

            cfg.CreateMap<Subject, SubjectDTO>();
            cfg.CreateMap<SubjectDTO, Subject>();

            cfg.CreateMap<Course, CourseDTO>();
            cfg.CreateMap<CourseDTO, Course>();

            cfg.CreateMap<Student_Course, Student_CourseDTO> ();
            cfg.CreateMap<Student_CourseDTO, Student_Course>();

            cfg.CreateMap<TestForm, TestFormDTO>();
            cfg.CreateMap<TestFormDTO, TestForm>();

            cfg.CreateMap<File_Exam, File_ExamDTO>();
            cfg.CreateMap<File_ExamDTO, File_Exam>();

            cfg.CreateMap<Class_Test, Class_TestDTO>();
            cfg.CreateMap<Class_TestDTO, Class_Test>();

            cfg.CreateMap<Student_File_Exam, Student_File_ExamDTO>();
            cfg.CreateMap<Student_File_ExamDTO, Student_File_Exam>();

            cfg.CreateMap<Student_Test, Student_TestDTO>();
            cfg.CreateMap<Student_TestDTO, Student_Test>();

            cfg.CreateMap<Result_Study, Result_StudyDTO>();
            cfg.CreateMap<Result_StudyDTO, Result_Study>();
        }
    }
}
