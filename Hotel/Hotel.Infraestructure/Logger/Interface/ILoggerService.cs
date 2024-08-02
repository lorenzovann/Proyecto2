

namespace Hotel.Infraestructure.Logger.Interface
{
    public interface ILoggerService
    {
        void LogInformation(string message);
        void LogError(string message);

    }
}
