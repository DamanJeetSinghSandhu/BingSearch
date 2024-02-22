
using Sink.Logger.Models;

namespace Sink.Logger.Lib.SinkInterface
{
    public interface ILogSink
    {
        void LogMessage(Location message);
    }
}
