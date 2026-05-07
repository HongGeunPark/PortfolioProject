using ASPWeb.Repositories;
using ASPWeb.Service;

var builder = WebApplication.CreateBuilder(args);

// 의존성 주입(DI) : Controller에서 Service를, Service에서 Repository를 직접 new 하지 않아도 ASP.NET이 알아서 만듬
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<CargoRepository>(x => new CargoRepository(connectionString));
builder.Services.AddScoped<CargoService>();

builder.Services.AddScoped<TariffRateRepository>(x => new TariffRateRepository(connectionString));
builder.Services.AddScoped<TariffCalcRepository>(x => new TariffCalcRepository(connectionString));
builder.Services.AddScoped<TariffService>();

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
