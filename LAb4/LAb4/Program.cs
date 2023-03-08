//Task 1(Welcome)
//Build an ASP.Net MVC application that displays the current system date and time and time zone.
//The information should be displayed on a new view and this view should be displayed when the application is run.
//The controller should work out what the current date and time are and pass them into the view as property of ViewBag.
//Use the existing default controller HomeController to achieve this.
//The view itself should work out the time zone and display that in addition to the date and time.
//Hint: use DateTime.Now and TimeZone.CurrentTimeZone.StandardName.Change the styling, use a red for html heading elements.


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
