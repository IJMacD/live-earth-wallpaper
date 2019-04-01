﻿using System;
using System.Threading;
using System.Threading.Tasks;
using LEWP.Common;

using LEWP.DSCOVR;
using LEWP.Himawari;

namespace LEWP.Core
{
    internal class Orchestrator
    {
        private readonly Action<NotifificationType, string> _notify;
        private CancellationTokenSource _internalTokenSource;

        public Orchestrator(Action<NotifificationType, string> notify)
        {
            _notify = notify;
        }

        public async Task DoWork(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var service = ServiceFactory();
                var imageFile = service?.GetImage(token);
                if (imageFile != null)
                {
                    Wallpaper.Set(imageFile, Wallpaper.Style.Fit);
                }

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
                case 0:
                    service = new DscovrService(_notify);
                    break;
                case 1:
                    service = new HimawariService(_notify);
                    break;
                case 2:
                    throw new NotImplementedException();
            }

            return service;
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
