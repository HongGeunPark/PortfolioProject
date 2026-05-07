using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Swagger UI 등록. 브라우저에서 /swagger 접속하면 API 목록 볼 수 있게 해주는 것.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PortfolioWeb API", Version = "v1" });
});
////////////////////////////////////////////////////////////////////////////////

// CORS - Vue 개발서버 허용
// 해당 설정이 없으면 Vue에서 API 호출시 브라우저에서 막음
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVue", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // Vue 개발 서버 기본포트 : 5173
              .AllowAnyHeader() // 어떤 헤더든 모두 허용
              .AllowAnyMethod(); // GET, POST, PUT, DELETE 전부 허용
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Docker 환경에서 개발할 때 HTTPS 설정이 복잡 해서 제외
//app.UseHttpsRedirection();
app.UseCors("AllowVue");

app.UseAuthorization();

app.MapControllers();

app.Run();
