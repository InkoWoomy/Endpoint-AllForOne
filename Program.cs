using Endpoint_AllForOne.Services.Mini1;
using Endpoint_AllForOne.Services.Mini2;
using Endpoint_AllForOne.Services.Mini3;
using Endpoint_AllForOne.Services.Mini4;
using Endpoint_AllForOne.Services.Mini5;
using Endpoint_AllForOne.Services.Mini6;
using Endpoint_AllForOne.Services.Mini7A;
using Endpoint_AllForOne.Services.Mini7B;
using Endpoint_AllForOne.Services.Mini8;
using Endpoint_AllForOne.Services.Mini9A;
using Endpoint_AllForOne.Services.Mini9B;
using Endpoint_AllForOne.Services.Mini9C;
using Endpoint_AllForOne.Services.Mini10;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMini1Service, Mini1Service>();
builder.Services.AddScoped<IMini2Service, Mini2Service>();
builder.Services.AddScoped<IMini3Service, Mini3Service>();
builder.Services.AddScoped<IMini4Service, Mini4Service>();
builder.Services.AddScoped<IMini5Service, Mini5Service>();
builder.Services.AddScoped<IMini6Service, Mini6Service>();
builder.Services.AddScoped<IMini7AService, Mini7AService>();
builder.Services.AddScoped<IMini7BService, Mini7BService>();
builder.Services.AddScoped<IMini8Service, Mini8Service>();
builder.Services.AddScoped<IMini9AService, Mini9AService>();
builder.Services.AddScoped<IMini9BService, Mini9BService>();
builder.Services.AddScoped<IMini9CService, Mini9CService>();
builder.Services.AddScoped<IMini10Service, Mini10Service>();

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
