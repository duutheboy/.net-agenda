using Microsoft.EntityFrameworkCore;
using SiteEmMVC.Data;
using SiteEmMVC.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BancoContext>
    (options => options.UseSqlServer
    ("Server=localhost\\MSSQLSERVER01;Database=DB_SistemaContatos;Trusted_Connection=True;TrustServerCertificate=True"));
// Corrigir erro "SSL PROVIDER error = 0" add parametro "TrustServerCertificate=True" na string de conexão

builder.Services.AddScoped<IContatoRepository, ContatoRepository>();

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
