using System;

namespace Vip.Logging {
    public interface ILoggerFactory {
        ILogger CreateLogger(Type type);
    }
}