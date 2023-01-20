using Microsoft.EntityFrameworkCore;
using Student.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentDbContext>(options =>
{
    options.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Student1;Integrated Security=True;Encrypt=False");
    //options.UseSqlServer(connection, b => b.MigrationsAssembly("GroceryAppAPI"));
});
builder.Services.Add(new ServiceDescriptor(typeof(IStudent), typeof(StudentDataAccessLayer), ServiceLifetime.Transient));
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
