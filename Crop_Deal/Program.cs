using Crop_Deal.Context;
using Crop_Deal.Infrastructure;
using Crop_Deal.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<IBank_Details, Bank_DetailsRepository>();
builder.Services.AddScoped<ICrops, CropRepository>();   
builder.Services.AddScoped<ICrop_Detail, Crop_DetailRepository>();
builder.Services.AddScoped<IInvoice, InvoiceRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register DbContext
var connectionString = builder.Configuration.GetConnectionString("connection");
builder.Services.AddDbContext<CD_DbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
