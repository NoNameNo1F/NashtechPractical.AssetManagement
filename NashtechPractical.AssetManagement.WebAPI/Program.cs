using NashtechPractical.AssetManagement.WebAPI.ConfigurationOptions;
using NashtechPractical.AssetManagement.WebAPI.ExceptionHandlers;
using NashtechPractical.AssetManagement.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var appSettings = new AppSettings();
configuration.Bind(appSettings);


builder.Services.AddInfrastructure(opt =>
    configuration.GetSection("Infrastructure").Bind(opt));

builder.Services.AddProblemDetails();
builder.Services.AddAuthentication();
builder.Services.AddExceptionHandler<ApiExceptionHandler>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services
    .AddSwaggerDocumentation()
    .AddVersioning();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerDocumentation();
}


app.UseCors();
app.UseHttpsRedirection();
app.UseExceptionHandler(_ => { });

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();