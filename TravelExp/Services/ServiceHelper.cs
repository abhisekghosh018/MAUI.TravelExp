namespace TravelExp.Services
{
    public static class ServiceHelper
    {
        public static IServiceProvider Services { get; set; } = default!;

        public static T GetService<T>() where T : class
            => Services.GetService<T>() ?? throw new InvalidOperationException($"Service {typeof(T)} not found.");
    }

}
