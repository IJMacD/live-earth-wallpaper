using System;
using System.Threading;
using System.Threading.Tasks;
using LEWP.Common;

using LEWP.DSCOVR;
using LEWP.Himawari;
using LEWP.APOD;

namespace LEWP.Core
{
    internal class Orchestrator
    {
        private readonly Action<NotifificationType, string> _notify;
        private CancellationTokenSource _internalTokenSource;

        public Orchestrator()
        {
            _notify = null;
        }

        public Orchestrator(Action<NotifificationType, string> notify)
        {
            _notify = notify;
        }

        public async Task DoWork(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                RunOnce(token);

                if (Settings.Default.Interval <= 0)
                {
                    continue;
                }

                _internalTokenSource = new CancellationTokenSource();
                using (var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(_internalTokenSource.Token, token))
                {
                    try
                    {
                        await Task.Delay(TimeSpan.FromMinutes(Settings.Default.Interval), linkedCts.Token);
                    }
                    catch
                    {
                        // ignore exception raised by token cancellation
                    }
                }
            }
        }

        private IImageSource ServiceFactory()
        {
            IImageSource service = null;
            switch (Settings.Default.Source)
            {
                case (int)ImageSources.DSCOVR:
                    service = new DscovrService(_notify);
                    break;
                case (int)ImageSources.Himawari:
                    service = new HimawariService(_notify);
                    break;
                case (int)ImageSources.APOD:
                    service = new APODService(_notify);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return service;
        }

        public void RunOnce (CancellationToken token)
        {
            var service = ServiceFactory();
            var imageFile = service?.GetImage(token);
            if (imageFile != null)
            {
                Wallpaper.Style style = Wallpaper.Style.Fill;
                if (Settings.Default.WallpaperStyle == 0)
                {
                    style = Wallpaper.Style.Fill;
                }
                else if (Settings.Default.WallpaperStyle == 1)
                {
                    style = Wallpaper.Style.Fit;
                }
                Wallpaper.Set(imageFile, style);
            }
        }

        public void ForceStart()
        {
            _internalTokenSource?.Cancel();
        }

        public bool CanForce()
        {
            return _internalTokenSource != null && !_internalTokenSource.Token.IsCancellationRequested;
        }
    }
}
