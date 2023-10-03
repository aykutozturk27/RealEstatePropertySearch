using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using RealEstatePropertySearch.Business.DependencyResolvers.Autofac;

var builder = WebApplication.CreateBuilder(args);

//Add hosts to the container.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new BusinessModule());
    builder.RegisterModule(new AutoMapperModule());
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors();
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

app.UseAuthorization();

app.MapControllers();

app.UseStaticFiles();

app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

app.Run();
