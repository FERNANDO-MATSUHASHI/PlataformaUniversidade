using DDD.Infra.SqlServerFisico;
using DDD.Infra.SqlServerFisico.Interfaces;
using DDD.Infra.SqlServerFisico.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//IOC (Inversion of Control) - Dependency Injection
//builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IAlunoRepository, AlunoRepositorySqlServer>();
builder.Services.AddScoped<SqlServerContext, SqlServerContext>();
// builder.Services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();

//builder.Services.AddScoped<APIContext, APIContext>();

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
