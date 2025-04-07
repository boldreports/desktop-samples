var builder = WebApplication.CreateBuilder(args);

// ✅ Register MemoryCache
builder.Services.AddMemoryCache();

// ✅ Register Controllers
builder.Services.AddControllers();

// ✅ Register Swagger (optional, for API documentation)
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();


app.UseCors("AllowAll"); // Enable CORS
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();
app.Run();

