using AspNetCoreCourse.Constraints;
using AspNetCoreCourse.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RouteOptions>(options =>options.ConstraintMap.Add("custom",typeof(CustomConstraint)));
builder.Services.AddAuthorization();
builder.Services.AddControllersWithViews();

#region IoC Ornek1
//builder.Services.AddControllersWithViews();
//builder.Services.Add(new ServiceDescriptor(typeof(ConsoleLog),new ConsoleLog())); //default olarak AddSingleton
//builder.Services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));   //default olarak AddSingleton
//builder.Services.Add(new ServiceDescriptor(typeof(PerformanceLog), new PerformanceLog(12))); //default olarak AddSingleton

//builder.Services.AddSingleton<ConsoleLog>();
//builder.Services.AddSingleton<TextLog>();
//builder.Services.AddSingleton<PerformanceLog>(p => new PerformanceLog(12));

//builder.Services.AddScoped<ConsoleLog>();
//builder.Services.AddScoped<TextLog>();
//builder.Services.AddScoped<PerformanceLog>(p => new PerformanceLog(12));

//builder.Services.AddTransient<ConsoleLog>();
//builder.Services.AddTransient<TextLog>();
//builder.Services.AddTransient<PerformanceLog>(p => new PerformanceLog(12));
#endregion


//builder.Services.AddScoped<ILog, PerformanceLog>(p=>new PerformanceLog(2));
//builder.Services.AddTransient<ILog, TextLog>();

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
