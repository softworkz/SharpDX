using System;
using Emby.Codecs.Dxva.Detection;
using Emby.Server.Implementations.Logging;

namespace DxvaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var logManager = new SimpleLogManager();

            using (var gip = new GraphicsInfrastructureProvider(logManager.GetLogger("DXGI")))
            {
                gip.Detect();
            }

            ////using (var detector = new MainDetector(logManager.GetLogger("Dxva")))
            ////{
            ////    detector.DoCodecs();
            ////}
        }
    }
}
