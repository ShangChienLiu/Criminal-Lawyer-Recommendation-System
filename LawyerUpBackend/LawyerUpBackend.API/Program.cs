using LawyerUpBackend.Application.Services;
using LawyerUpBackend.Application.Services.Impl;
using LawyerUpBackend.Application;
using LawyerUpBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDatabaseServices(builder.Configuration);

builder.Services.AddApplication(builder.Configuration); //Extension Method in Application Library
builder.Services.AddCors(options =>
    options.AddPolicy("CorsPolicy", policy =>
     {
         policy.AllowAnyHeader();
         policy.AllowAnyMethod();
         policy.AllowAnyOrigin();
     }));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("CorsPolicy");
app.MapControllers();

app.Run();
