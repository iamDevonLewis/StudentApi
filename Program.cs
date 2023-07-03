using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = "server=localhost;user=student;password=student;database=student";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 32));
// Add database
builder.Services.AddDbContext<ApplicationDbContext>(dbContextOptions => dbContextOptions.UseMySql(connectionString, serverVersion));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("angularApp", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Configure AutoMapper
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("angularApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
