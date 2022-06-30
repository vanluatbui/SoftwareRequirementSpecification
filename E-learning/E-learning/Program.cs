using E_learning;
using E_learning.Repositories;
using E_learning.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// ---------------------------------------------------

builder.Services.AddSingleton<ApplicationDbContext>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")),
ServiceLifetime.Singleton);

builder.Services.AddTransient<ILeaderShipRepository, LeaderShipRespository>();
builder.Services.AddTransient<LeaderShipService>();

builder.Services.AddTransient<ITeacherRepository, TeacherRespository>();
builder.Services.AddTransient<TeacherService>();

builder.Services.AddTransient<ISemesterRepository, SemesterRespository>();
builder.Services.AddTransient<SemesterService>();

builder.Services.AddTransient<IClassRepository, ClassRespository>();
builder.Services.AddTransient<ClassService>();

builder.Services.AddTransient<IStudentRepository, StudentRespository>();
builder.Services.AddTransient<StudentService>();

builder.Services.AddTransient<ISubjectRepository, SubjectRespository>();
builder.Services.AddTransient<SubjectService>();

builder.Services.AddTransient<ICourseRepository, CourseRespository>();
builder.Services.AddTransient<CourseService>();

builder.Services.AddTransient<IStudent_CourseRepository, Student_CourseRespository>();
builder.Services.AddTransient<Student_CourseService>();

builder.Services.AddTransient<ITestFormRepository, TestFormRespository>();
builder.Services.AddTransient<TestFormService>();

builder.Services.AddTransient< IFile_ExamRepository, File_ExamRespository>();
builder.Services.AddTransient< File_ExamService>();

builder.Services.AddTransient<IClass_TestRepository, Class_TestRespository>();
builder.Services.AddTransient<Class_TestService>();

builder.Services.AddTransient< IStudent_File_ExamRepository, Student_File_ExamRespository>();
builder.Services.AddTransient< Student_File_ExamService>();

builder.Services.AddTransient<IStudent_TestRepository, Student_TestRespository>();
builder.Services.AddTransient<Student_TestService>();

builder.Services.AddTransient<IResult_StudyRepository, Result_StudyRespository>();
builder.Services.AddTransient<Result_StudyService>();

//-----------------------------------------------------------------------

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
