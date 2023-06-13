using Microsoft.EntityFrameworkCore;
using projeto_test;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>(

    option => option.UseSqlServer("Server=201.55.32.20;Database=INFOMED;User Id=pw_tarde;Password=aluno123;Encrypt=True; TrustServerCertificate=true;")
    //option => option.UseSqlServer("Server=18.229.173.72\\APIMOBILE2023,1433;Database=INFOMED;User Id=sa;Password=991292994@eD;")
    //option => option.UseSqlServer("Server=c3po;Database= ;Trusted_Connection=True;")
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
