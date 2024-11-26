using AspNetCoreApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

//app.UseMiddleware<ResponseEditingMiddleware>();
//app.UseMiddleware<RequestEditingMiddleware>();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{Controller}/{Action}", // Urldeki ilk '/' i controller olarak al, sonraki '/'i Action olarak al.
        defaults: new {Controller = "Home", Action = "Index"} // E�er bo� bir url gelirse, default olarak home controller�ndan index action'�n� �a��r.
        );
});

app.UseAuthorization();

app.MapRazorPages();

app.Run();
