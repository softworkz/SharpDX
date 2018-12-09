

using System;
using MediaBrowser.Model.Logging;
using SharpDX.Mathematics.Interop;

namespace DxvaTest
{
    public class GraphicsInfrastructureProvider : IDisposable
    {
        private readonly ILogger logger;
        public GraphicsInfrastructureProvider(ILogger logger)
        {
            this.logger = logger;
        }

        public void Detect()
        {
            var factory = new SharpDX.DXGI.Factory4();

            var adapterCount = factory.GetAdapterCount1();

            this.logger.Info("Detected {0} video adapters.", adapterCount);

            for(int i = 0; i < adapterCount; i++)
            {
                var adapter = factory.GetAdapter1(i);
                this.logger.Info("Adapter {0}: {1}", i, adapter.Description1.Description);
                int n = 0;
                foreach(var output in adapter.Outputs)
                {
                    var desc = output.Description;
                    this.logger.Info("         Output {0}: {1} Active: {2} Bounds: {3}", n++, desc.DeviceName, desc.IsAttachedToDesktop, RawRectToString(desc.DesktopBounds));
                }
            }
        }

        private string RawRectToString(RawRectangle rect)
        {
            return string.Format("{0},{1} {2},{3}", rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        public void Dispose() { }
    }
}
