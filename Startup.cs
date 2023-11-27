public void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IContactRepository, ContactRepository>();
}