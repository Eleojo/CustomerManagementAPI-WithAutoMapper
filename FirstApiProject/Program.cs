using Api;
using Asp.Versioning;
using Core;
using Data.AppDbContext;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context,LoggerConfig) => LoggerConfig.ReadFrom.Configuration(context.Configuration));
// Add services to the container.
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddScoped<ICustomerService, CustomerService>();


var ConnString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(ConnString));

// Adding ApiVersioning
var DefaultApiVersion = new ApiVersion(1, 0);


builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = DefaultApiVersion;
    options.AssumeDefaultVersionWhenUnspecified = false;
    options.ReportApiVersions = true;
    options.ApiVersionReader = new Asp.Versioning.UrlSegmentApiVersionReader();
}).AddApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
    options.DefaultApiVersion = DefaultApiVersion;
}).EnableApiVersionBinding();


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
