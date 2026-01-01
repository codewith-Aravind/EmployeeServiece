using employeeService.API.Middlewares;
using employeeService.Core;
using employeeService.Core.Mappers;
using employeeService.Core.RepositoryContracts;
using employeeServices.Infrastructure.EmployeeDbContext;
using employeeServices.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

string? ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<EmployeeDbContext>(options =>
    options.UseSqlServer(ConnectionString)
);


builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddCoreServices();


builder.Services.AddControllers();

builder.Services.AddSwaggerGen();


// Fluent Validation
builder.Services.AddFluentValidationAutoValidation();

//builder.Services.AddAutoMapper(typeof(ContractEmployeeMappingProfile).Assembly);

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile(new ContractEmployeeMappingProfile());
});


var app = builder.Build();

// custom middleware to handle exceptions globally

app.UseGlobalExceptionHandlingMiddleware();

//app.UseMiddleware<ExceptionHandlingMiddleware>();

//swagger
app.UseSwagger();
app.UseSwaggerUI();

//Auth
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
