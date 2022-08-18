using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TTC.Win.Utils;

namespace TTC.Win.Helper
{
    internal static class ProxyHelper
    {

        internal static async Task<bool> DirectTiktok()
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry("www.tiktok.com");
            
            bool flag = false;
            if( iPHostEntry.AddressList.Length > 0)
            {
                string ip = iPHostEntry.AddressList[0].ToString();
                return await Check(ip, 80, "www.tiktok.com");
            }
           

            return flag;
        }
        internal static async Task<bool> Check(string uri, string msg)
        {
            Uri url = new Uri(uri);
            if (url.IsAbsoluteUri)
            {
                return await Check(url.Host, url.Port, msg);
            }
            return false;
        }
        internal static async Task<bool> Check(string ip, int port, string msg)
        {
            bool flag=false;
            var time = await Tcping.Ping5Async(ip, port);
            LogHelper.Log($"check {ip}:{port} ... ");
            if (time < 10.00)
            {
                LogHelper.LogAppend($"active");
                flag = true;
            }
            else 
            {
                LogHelper.LogAppend($"unactive");
                flag = false;
            }
            LogHelper.LogAppend($" [{msg}], time {time:000.000}S");

            return flag;
        }

    }
}
