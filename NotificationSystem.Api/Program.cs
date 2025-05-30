using NotificationSystem.Core.Interfaces;
using NotificationSystem.Core.Services;
using NotificationSystem.Providers.Email;
using NotificationSystem.Providers.Push;
using NotificationSystem.Providers.SMS;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers()
                .AddJsonOptions(options =>
                 {
                     options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                 });

builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<INotificationProvider, EmailNotificationProvider>();
builder.Services.AddScoped<INotificationProvider, TwilioNotificationProvider>();
builder.Services.AddScoped<INotificationProvider, FirebasePushProvider>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
