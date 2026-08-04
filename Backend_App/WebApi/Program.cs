using Microsoft.EntityFrameworkCore;
using Backend_App.Domain.Model;
using Backend_App.DataModel.Repository;
using Backend_App.Application.Services;
 
var builder = WebApplication.CreateBuilder(args);
 
// --- Services ---------------------------------------------------------
 
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Default")));
 
builder.Services.AddScoped<ExcelImportService>();
 
// Repository layer (data access)
builder.Services.AddScoped<IClassificationRepository, ClassificationRepository>();
builder.Services.AddScoped<ICountrySummaryRepository, CountrySummaryRepository>();
 
// Service layer (business logic)
builder.Services.AddScoped<IResultsService, ResultsService>();
builder.Services.AddScoped<IEntriesService, EntriesService>();
builder.Services.AddScoped<ICountriesService, CountriesService>();
 
var allowedOrigin = builder.Configuration["Cors:AllowedOrigin"] ?? "http://localhost:4200";
builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
        policy.WithOrigins(allowedOrigin)
              .AllowAnyHeader()
              .AllowAnyMethod());
});
 
var app = builder.Build();
 
// --- Ensure DB exists and is populated (runs the Excel import once) ---
 
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var importer = scope.ServiceProvider.GetRequiredService<ExcelImportService>();
    var excelPaths = app.Configuration.GetSection("Import:ExcelFilePaths").Get<string[]>()
        ?? new[]
        {
            app.Configuration["Import:ExcelFilePath"] ?? "docs/Paris2024_MilanoCortina2026.xlsx",
            "docs/LosAngeles2028_FrenchAlps2030.xlsx"
        };

    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    foreach (var excelPath in excelPaths)
    {
        var fullPath = Path.Combine(AppContext.BaseDirectory, excelPath);
        importer.Import(fullPath, db);
    }
}
 
// --- Middleware pipeline ------------------------------------------------
 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 
app.UseCors("Frontend");
app.UseAuthorization();
app.MapControllers();
 
app.Run();