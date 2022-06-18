using E_learning;
using E_learning.Entity;
using E_learning.Repositories;
using E_learning.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//-------------------------------------------------

builder.Services.AddSingleton<ApplicationDbContext>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")),
ServiceLifetime.Singleton);

builder.Services.AddIdentityCore<AspNetUser>(options =>
options.SignIn.RequireConfirmedAccount = true)
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>();

//==========================================================

//...

//===========================================================

builder.Services.AddTransient<IKhoaHocRepository, KhoaHocRespository>();
builder.Services.AddTransient<KhoaHocService>();

builder.Services.AddTransient<ILopRepository, LopRespository>();
builder.Services.AddTransient<LopService>();

builder.Services.AddTransient<ILop_HocSinhRepository, Lop_HocSinhRespository>();
builder.Services.AddTransient<Lop_HocSinhService>();

builder.Services.AddTransient<IMonHocRepository, MonHocRespository>();
builder.Services.AddTransient<MonHocService>();

builder.Services.AddTransient<ILop_MonHocRepository, Lop_MonHocRespository>();
builder.Services.AddTransient<Lop_MonHocService>();


builder.Services.AddTransient<IThoiKhoaBieuRepository, ThoiKhoaBieuRespository>();
builder.Services.AddTransient<ThoiKhoaBieuService>();

//-------------------------------------------------

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

app.UseAuthentication();

app.MapControllers();

app.Run();
