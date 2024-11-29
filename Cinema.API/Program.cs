using Cinema.API.Extensions;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext(builder.Configuration);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAutoMapper();
builder.Services.AddHangfire(builder.Configuration);

StripeConfiguration.ApiKey = builder.Configuration["Payments:Stripe:ApiKey"];

builder.Services.AddIdentity();
builder.Services.AddJwtAuthentication(builder.Configuration);

builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddEmailService(builder.Configuration);

builder.Services.AddTokenInSwagger();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
    {
        builder.WithOrigins("http://localhost:3000") 
            .AllowAnyMethod()  // Дозволяє будь-які HTTP методи (GET, POST, etc.)
            .AllowAnyHeader(); // Дозволяє будь-які заголовки
    });
});

var app = builder.Build();
app.CreateRoles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowSpecificOrigin");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
