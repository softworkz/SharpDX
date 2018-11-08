using System;
using System.Collections.Generic;
using System.Text;
using MediaBrowser.Model.Logging;
using SharpDX.Direct3D9;
using SharpDX.MediaFoundation.DirectX;
using DeviceType = SharpDX.Direct3D9.DeviceType;

namespace Emby.Codecs.Dxva.Detection
{
    public class DeviceCodecEnumerator : IDisposable
    {
        public CreateFlags DeviceCreationFlags = CreateFlags.SoftwareVertexProcessing | CreateFlags.Multithreaded | CreateFlags.FpuPreserve;
        private readonly ILogger logger;
        private Device d3dDevice;

        public DeviceCodecEnumerator(ILogger logger, Direct3D d3d, DisplayMode currentDisplayMode)
        {
            this.logger = logger;

            var presentationParam = CreatePresentationParams(currentDisplayMode.Format);

            this.d3dDevice = new Device(d3d, 0, DeviceType.Hardware, IntPtr.Zero, DeviceCreationFlags, presentationParam);

            this.logger.Info("Device successfully created: {0}", this.d3dDevice);
        }

        public void DoCodecs()
        {
            using (var decoderService = new VideoDecoderService(this.d3dDevice))
            {
                this.logger.Info("VideoDecoderService successfully created: {0}", this.d3dDevice);

                int count = 0;
                var guids = new Guid[100];
                decoderService.GetDecoderDeviceGuids(out count, guids);

                this.logger.Info("GetDecoderDeviceGuids returned {0} items", count);

                ////int count2 = 1;
                ////var guids2 = new List<string>();
                ////decoderService.GetDecoderDeviceGuids2(out count2, guids2);

                ////this.logger.Info("GetDecoderDeviceGuids returned {0} items: {1}", count2, string.Join(", ", guids2));

            }
        }

        private static PresentParameters CreatePresentationParams(Format backBufferFormat)
        {
            return new PresentParameters
            {
                Windowed         = true,
                BackBufferWidth  = 640,
                BackBufferHeight = 480,
                BackBufferFormat = backBufferFormat,
                SwapEffect       = SwapEffect.Discard,
                PresentFlags     = PresentFlags.Video
            };
        }

        public void Dispose()
        {
            if (this.d3dDevice != null)
            {
                this.d3dDevice.Dispose();
                this.d3dDevice = null;
            }
        }
    }
}
