using ASM.IServices;
using ASM.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddTransient<IUserServices, UserServices>();
builder.Services.AddTransient<IBillServices, BillServices>();
builder.Services.AddTransient<ICartServices, CartServices>();
builder.Services.AddTransient<IRoleServices, RoleServices>();
builder.Services.AddTransient<CartDetailService, CartDetailService>();
builder.Services.AddTransient<BillDetailsService, BillDetailsService>();
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromSeconds(300); });
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
app.UseSession();
app.MapControllerRoute("default", "{controller=Admin}/{action=Index}/{id?}");

app.Run();
