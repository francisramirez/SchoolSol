using Microsoft.EntityFrameworkCore;
using PoliSchool.DAL.Context;
using PoliSchool.DAL.Daos;
using PoliSchool.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Agregar conexion de la base datos.
builder.Services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDbContext")));


// Agregar al contenador el DAO (Student) //
builder.Services.AddTransient<IStudentDao, StudentDao>();
builder.Services.AddTransient<IDepartmentDao, DepartmentDao>();
builder.Services.AddTransient<ICourseDao, CourseDao>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
