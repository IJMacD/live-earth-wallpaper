using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using LEWP.Common;

using Newtonsoft.Json;

namespace LEWP.APOD
{
    public class APODService : IImageSource
    {
        private readonly Action<NotifificationType, string> _notify;

        public APODService(Action<NotifificationType, string> notify)
        {
            _notify = notify;
        }

        public string GetImage(CancellationToken token)
        {
            var imageInfo = GetLatestImageInfo();
            if (imageInfo == null)
            {
                return null;
            }

            return AssembleImageFrom(imageInfo);
        }

        private ImageInfo GetLatestImageInfo()
        {
            var date = DateTime.Now.ToUniversalTime();
            ImageInfo image = null;
            var tries = 0;
            do
            {
                tries++;
                var dateString = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                var cUrl = $"https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY&date={dateString}";
                try
                {
                    using (var wc = new WebClient())
                    {
                        var json = wc.DownloadString(cUrl);
                        image = JsonConvert.DeserializeObject<ImageInfo>(json);
                    }
                }
                catch (WebException ex)
                {
                    _notify?.Invoke(NotifificationType.Error, "Error receiving image information: " + ex.Message);
                }
                catch (Exception ex)
                {
                    _notify?.Invoke(NotifificationType.Error, "Unknown error receiving image information: " + ex.Message);
                    throw;
                }
                date = date.AddDays(-1);
            } while ((image == null || image.Media_type != "image") && tries < 10);

            if (image == null)
            {
                _notify?.Invoke(NotifificationType.Error, "Could not find any image to set as background.");
                return null;
            }

            return image;
        }

        private string AssembleImageFrom(ImageInfo imageInfo)
        {
            var url = imageInfo.Hdurl;
            var pathName = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Earth\apod-latest.jpg";
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(pathName)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(pathName));
                }

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(url, pathName);
                }
            }
            catch (WebException ex)
            {
                _notify?.Invoke(NotifificationType.Error, "Error downloading image: " + ex.Message);
            }
            catch (Exception ex)
            {
                _notify?.Invoke(NotifificationType.Error, "Unknown error downloading image: " + ex.Message);
                throw;
            }

            return pathName;
        }
    }
}