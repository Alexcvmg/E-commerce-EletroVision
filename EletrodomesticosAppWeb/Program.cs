using EletrodomesticosAppWeb.Data;
using EletrodomesticosAppWeb.Servico;
using EletrodomesticosAppWeb.Servico.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<IEletrodomesticoService, EletrodomesticoService>();

builder.Services.AddDbContext<EletrodomesticoDbContext>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

var context = new EletrodomesticoDbContext();
context.Database.Migrate();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
