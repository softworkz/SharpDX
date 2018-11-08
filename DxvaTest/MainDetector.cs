using System;
using System.Collections.Generic;
using System.Text;
using MediaBrowser.Model.Logging;
using SharpDX.Direct3D9;

namespace Emby.Codecs.Dxva.Detection
{
    internal class MainDetector : IDisposable
    {
        private readonly ILogger logger;
        private Direct3D d3d;

        public MainDetector(ILogger logger)
        {
            this.logger = logger;
            this.d3d = new Direct3D();
        }

        public void DoCodecs()
        {
            this.logger.Info("Detected {0} video adapters.", this.d3d.AdapterCount);

            foreach (var adapter in this.d3d.Adapters)
            {
                this.logger.Info("Adapter #{0}: '{1}' {2} (Driver: {3})", adapter.Adapter, adapter.Details.DeviceName, adapter.Details.Description, adapter.Details.DriverVersion);
                this.logger.Info("    Current DisplayMode: {0}", adapter.CurrentDisplayMode);

                using (var codecEnum = new DeviceCodecEnumerator(logger, this.d3d, adapter.CurrentDisplayMode))
                {
                    codecEnum.DoCodecs();
                }
            }
        }

        public void Dispose()
        {
            if (this.d3d != null)
            {
                this.d3d.Dispose();
                this.d3d = null;
            }
        }
    }
}
