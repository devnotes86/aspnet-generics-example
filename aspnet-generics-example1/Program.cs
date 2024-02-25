using aspnet_generics_example1;
using Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
 
 

builder.Services.AddControllers(); 
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// inject VehiclesService implementation
builder.Services.AddTransient<IVehiclesService, VehiclesService>();


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

app.UseMvc( );

app.Run(); 