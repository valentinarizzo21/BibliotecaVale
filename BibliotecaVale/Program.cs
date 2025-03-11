using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Aggiungi i servizi al contenitore.
builder.Services.AddDbContext<BibliotecaValeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaValeDb")));
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<LibroService>();
var app = builder.Build();

// Configura la pipeline delle richieste HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
