//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using Hart.Extensions;


//--------------------------------------------------------------------------
// Program Section
//--------------------------------------------------------------------------
var builder = WebApplication.CreateBuilder(args);

//--------------------------------------------------------------------------
// Add services to the container
//--------------------------------------------------------------------------
builder.Services.ConfigureCors();
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLogger();
builder.Services.ConfigureConnectionString(builder.Configuration);
builder.Services.ConfigureDataContext();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureSwagger();

//--------------------------------------------------------------------------
// Builder
//--------------------------------------------------------------------------
var app = builder.Build();

//--------------------------------------------------------------------------
// Configure the HTTP request pipeline
//--------------------------------------------------------------------------
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");
app.MapFallbackToFile("index.html");


//--------------------------------------------------------------------------
// Run App
//--------------------------------------------------------------------------
app.Run();
