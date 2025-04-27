using ship_management;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.MapGet("/api/ships/passenger", (Passenger_ship ship, ShipRegistry registry) =>
{
    registry.AddShip(ship);
    return Results.Ok();
});

app.MapGet("app/ships/tanker", (Tanker_ship ship, ShipRegistry registry) =>
{
    registry.AddShip(ship);
    return Results.Ok();
});


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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
