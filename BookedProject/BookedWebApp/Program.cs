using Booked.Infrastructure.Repositories;
using Booked.Logic.Interfaces;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
    options.LoginPath = new PathString("/Login");
    options.AccessDeniedPath = new PathString("/AccessDenied");
}
);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<BookingManager>();

//builder.Services.AddScoped<HotelBookingManager>();
builder.Services.AddScoped<IHotelBookingRepo, HotelBookingRepository>();

builder.Services.AddScoped<HotelManager>();
builder.Services.AddScoped<IHotelRepo, HotelRepository>();

//builder.Services.AddScoped<FlightBookingManager>();
builder.Services.AddScoped<IFlightBookingRepo, FlightBookingRepository>();

builder.Services.AddScoped<FlightManager>();
builder.Services.AddScoped<IFlightRepo, FlightRepository>();

builder.Services.AddScoped<UserManager>();
builder.Services.AddScoped<IUserRepo, UserRepository>();

builder.Services.AddScoped<ReviewManager>();
builder.Services.AddScoped<IReviewRepo, ReviewRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
