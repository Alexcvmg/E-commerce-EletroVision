using EletrodomesticosAppWeb.Data;
using EletrodomesticosAppWeb.Servico;
using EletrodomesticosAppWeb.Servico.Data;

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

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
