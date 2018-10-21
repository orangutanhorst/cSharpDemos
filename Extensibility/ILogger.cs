using System;

namespace Extensibility
{
    public interface ILogger
    {
        void LogError(String message);
        void LogInfo(String message);
    }
}