using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TTC.Win.Extensions;

namespace TTC.Win.Utils
{
    internal static class WebpConverter
    {
        internal static HttpClient HttpClient = null;
        private static readonly string _iconTempPath = Path.Combine(Path.GetTempPath(), "ttc", "icon");

           
        internal static async Task<string> StorageAsync(string fileName, string url)
        {
            if(new Uri(url).IsAbsoluteUri && HttpClient.Legal())
            {
                try
                {
                    if (!Directory.Exists(_iconTempPath))
                        Directory.CreateDirectory(_iconTempPath);
                    string localFileName = Path.Combine(_iconTempPath, fileName);
                    if (!File.Exists(localFileName))
                    {
                        byte[] urlContents = await HttpClient.GetByteArrayAsync(url);
                        Bitmap img = new Imazen.WebP.SimpleDecoder().DecodeFromBytes(urlContents, urlContents.Length);
                        img.Save(localFileName);
                    }
                    return localFileName;
                }
                catch { throw;  }
            }
            return null;
        }
    }
}
