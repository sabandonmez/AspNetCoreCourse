using AspNetCoreCourse.AutoMapper;
using AspNetCoreCourse.Constraints;
using AspNetCoreCourse.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RouteOptions>(options =>options.ConstraintMap.Add("custom",typeof(CustomConstraint)));
builder.Services.AddAuthorization();
builder.Services.AddControllersWithViews();


builder.Services.AddAutoMapper(typeof(PersonelProfil));
builder.Services.AddSingleton<ILog, ConsoleLog>();


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

app.UseEndpoints(endpoints => {

    //endpoints.MapControllerRoute("CustomParametreliRoute","{controller=Home}/{action=Index}/{id:custom?}/{x?}/{y:int?}");
    //endpoints.MapDefaultControllerRoute();

    //endpoints.MapControllers();

});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
