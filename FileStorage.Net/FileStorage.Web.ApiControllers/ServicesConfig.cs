using FileStorage.Repository;
using FileStorage.Repository.EF;

public static class ServicesConfig {
    private static IFileStorage getFileStorage() {
        return new EfFileStorage(System.Configuration.ConfigurationManager.ConnectionStrings["EfFileStorage"]?.ConnectionString);
    }
    public static IServiceCollection AddServices(this IServiceCollection services) {
        services.AddScoped<IFileStorage>((_) => getFileStorage());
        return services;
    }
}