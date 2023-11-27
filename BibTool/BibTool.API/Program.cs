using BibTool.API.Services.AuthorService;
using BibTool.API.Services.BookService;
using BibTool.API.Services.UserService;
using BibTool.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using RecipePlatformApi.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BibToolContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Manuel"),b => b.MigrationsAssembly("BibTool.API"));
});

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

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