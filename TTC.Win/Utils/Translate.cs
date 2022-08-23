using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TTC.Win.Utils
{
    internal static class Translate
    {

        private static void SetQ(in HttpWebRequest httpWebRequest)
        {
            httpWebRequest.Method = "GET";
            httpWebRequest.KeepAlive = false;
            httpWebRequest.ProtocolVersion = HttpVersion.Version10;

            httpWebRequest.Headers.Add("Accept-Encoding", "utf-8");
            httpWebRequest.Headers.Add("Accept-Language", "zh-CN,zh;q=0.9");
            httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            httpWebRequest.ContentType = "text/html; charset=utf-8";
            httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
            httpWebRequest.Method = "GET";
            httpWebRequest.Timeout = 8000;
            httpWebRequest.ReadWriteTimeout = 8000;
            httpWebRequest.ProtocolVersion = HttpVersion.Version11;
        }

        /// <summary>
        /// 根据api获取翻译
        /// </summary>
        /// <param name="str">需要翻译的内容</param>
        /// <param name="Translattype">目标翻译类型:传入使用GetRequestLang所获得的值</param>
        /// <returns></returns>
        public static async Task<string> GetGoogleApiResAsync(string str, string Translattype = "zh-CN")
        {
            string res = null;
            await Task.Run(() =>
            {
                
                string apiurl = "http://translate.google.cn/translate_a/single?client=gtx&dt=t&dj=1&ie=UTF-8&sl=auto&tl=" + Translattype + "&q=" + str;
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(apiurl);

                SetQ(in myRequest);

                HttpWebResponse response = (HttpWebResponse)myRequest.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

                //返回内容
                string hq = myStreamReader.ReadToEnd();
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(hq);
                
                try
                {
                    res = data.sentences[0].trans.ToString();
                }
                catch (Exception)
                {
                    res = str;
                }
            });
            return res;
        }
    }
}
