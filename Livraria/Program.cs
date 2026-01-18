using Microsoft.EntityFrameworkCore;
using Livraria.Infrastructure;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LivrariaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LivrariaConnection"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirReact", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // Endereço padrão do Vite/React
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

var nomeDoProjeto = app.Configuration.GetValue<string>("NomeDoProjeto");

Console.WriteLine($"#######################{nomeDoProjeto}###########################");

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    options.RoutePrefix = "swagger"; // UI disponível em /swagger
});

app.UseHttpsRedirection();

app.UseCors("PermitirReact");

app.UseAuthorization();

app.MapControllers();

app.Run();
