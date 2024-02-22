using Sink.Logger.Lib.SinkInterface;
using Sink.Logger.Models;

namespace Sink.Logger.Lib
{
    public class ConsoleSink : ILogSink
    {
        public void LogMessage(Location message)
        {
            // printing logs in the console 
            Console.WriteLine($"{message.Level}: [{message.Namespace}] - {message.Content}");
        }
    }
}
