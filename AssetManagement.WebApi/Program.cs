using AssetManagement.BC;
using AssetManagement.BC.BuisinessComponents;
using AssetManagement.Data;
using AssetManagement.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager config = builder.Configuration;

builder.Services.AddDbContext<AssetManagementContext>(options => options.UseSqlServer(config.GetConnectionString("AssetDatabase")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IAssetDetailRepository, AssetDetailRepository>();
builder.Services.AddScoped<IAssetDetailBC, AssetDetailBC>();

builder.Services.AddScoped<IIconRepository, IconRepository>();
builder.Services.AddScoped<IIconBC, IconBC>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserBC, UserBC>();

builder.Services.AddScoped<IAssetRepository, AssetRepository>();
builder.Services.AddScoped<IAssetBC, AssetBC>();

builder.Services.AddScoped<IAssetTypeRepository, AssetTypeRepository>();
builder.Services.AddScoped<IAssetTypeBC, AssetTypeBC>();

builder.Services.AddScoped<IAccessLevelRepository, AccessLevelRepository>();
builder.Services.AddScoped<IAccessLevelBC, AccessLevelBC>();

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
