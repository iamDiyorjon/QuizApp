using QuizApp.Api.Extensions;
using QuizApp.Application;
using QuizApp.Infrastructure;

namespace QuizApp.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddInfrastructure(builder.Configuration)
            .AddApplication()
            .AddApis();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}