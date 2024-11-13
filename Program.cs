using UserView.Models;
using UserView.Services;

var builder = WebApplication.CreateBuilder(args);
var photoService = new PhotoRequestService();
var photoTask = photoService.GetPhotoDataFromConsoleAsync();
photoTask.Wait();  
var photo = photoTask.Result;

builder.Services.AddSingleton(photo);
builder.Services.AddSingleton(provider => new InfoRequestService().GetPersonFromConsole());

var app = builder.Build();

app.MapGet("/name", (Person person) => $"{person.Name} {person.Surname}");
app.MapGet("/group", (Person person) => person.Group);
app.MapGet("/about", (Person person) => $"About user: {person.YearAtUniversity}-year, {person.Hobbies}");
app.MapGet("/photo", async (Photo photo, HttpContext context) =>
{
    try
    {
        context.Response.ContentType = "image/jpeg";
        await context.Response.Body.WriteAsync(photo.PhotoData, 0, photo.PhotoData.Length);
    }
    catch (FileNotFoundException)
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("No images were found!");
    }
});

app.Run();