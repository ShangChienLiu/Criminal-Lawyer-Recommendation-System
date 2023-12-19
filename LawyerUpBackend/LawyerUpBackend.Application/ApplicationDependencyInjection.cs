using LawyerUpBackend.Application.Services;
using LawyerUpBackend.Application.Services.Impl;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace LawyerUpBackend.Application;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddServices();
        services.AddPythonServices(configuration);

        return services;
    }

    public static void AddServices(this IServiceCollection services)
    {
        //services.AddScoped<IPredictionModelService, PredictionModelService>();
        services.AddScoped<ILawyerService, LawyerService>();
        services.AddScoped<ICaseService, CaseService>();

    }

    public static void AddPythonServices(this IServiceCollection services,IConfiguration configuration)
    {
        string pythonPATH = configuration.GetSection("Python").GetSection("Python_ENV").Value;
        string executePATH = configuration.GetSection("Python").GetSection("ExecutePath").Value;
        services.AddTransient<IPredictionModelService>(provider => new PredictionModelService(pythonPATH,executePATH));
    }
    
}
