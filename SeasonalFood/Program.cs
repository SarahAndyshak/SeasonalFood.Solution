using SeasonalFood.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var devCorsPolicy = "devCorsPolicy";
builder.Services.AddCors(options => options.AddPolicy(devCorsPolicy, builder =>
    {
    builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    }));

builder.Services.AddDbContext<SeasonalFoodContext>(
                    dbContextOptions => dbContextOptions
                    .UseMySql(
                        builder.Configuration["ConnectionStrings:DefaultConnection"], 
                        ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                )
            );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else 
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.UseCors(devCorsPolicy);

app.Run();