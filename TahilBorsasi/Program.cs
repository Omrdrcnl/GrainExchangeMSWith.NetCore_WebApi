using TahilBorsasi.Repository;
using Microsoft.EntityFrameworkCore;
using TahilBorsasi.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RepositoryContext>(options => options.UseSqlServer("Data Source=OMER-DIRICANLI\\SQLEXPRESS; " +
    "Initial Catalog=DbGrainExchange; Integrated Security=True; TrustServerCertificate=True"));
builder.Services.AddScoped<ProductNameRepository, ProductNameRepository>();
builder.Services.AddScoped<FarmerRepository, FarmerRepository>();
builder.Services.AddScoped<TradesmanRepository, TradesmanRepository>();
// Add services to the container.

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
