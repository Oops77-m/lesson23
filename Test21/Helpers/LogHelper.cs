using log4net;
using log4net.Config;

namespace Test21.Helpers;

public static class LogHelper
{
    private static readonly ILog _logger = LogManager.GetLogger(typeof(LogHelper));

    // Статический конструктор — инициализация log4net ОДИН раз
    static LogHelper()
    {
        var projectDirectory = Path.GetFullPath(
            Path.Combine(AppContext.BaseDirectory, "..", "..", "..")
        );

        var logDirectory = Path.Combine(projectDirectory, "logs");

        Directory.CreateDirectory(logDirectory);

        GlobalContext.Properties["LogDirectory"] = logDirectory;

        var configPath = Path.Combine(
            AppContext.BaseDirectory,
            "log4net.config"
        );

        XmlConfigurator.Configure(new FileInfo(configPath));

        _logger = LogManager.GetLogger(typeof(LogHelper));
    }

    public static void Info(string message) => _logger.Info(message);

    public static void Warn(string message) => _logger.Warn(message);

    public static void Error(string message) => _logger.Error(message);

    public static void Error(string message, Exception ex) =>
        _logger.Error(message, ex);

    public static void Debug(string message) => _logger.Debug(message);

    public static void Fatal(string message) => _logger.Fatal(message);

}