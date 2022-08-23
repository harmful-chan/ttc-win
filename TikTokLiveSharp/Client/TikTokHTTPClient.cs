﻿using Newtonsoft.Json.Linq;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TikTokLiveSharp.Client.Proxy;
using TikTokLiveSharp.Client.Requests;
using TikTokLiveSharp.Protobuf;

namespace TikTokLiveSharp.Client
{
    public class TikTokHTTPClient
    {
        public event EventHandler<System.IO.Stream> OnDeserializedMessageSave;

        public TikTokHTTPClient()
        {

        }

        internal TikTokHTTPClient(TimeSpan? timeout, WebProxy proxyHandler = null, CookieContainer cookieContainer = null)
        {
            TikTokHttpRequest.Timeout = timeout ?? TimeSpan.FromSeconds(10);
            TikTokHttpRequest.WebProxy = proxyHandler;
            TikTokHttpRequest.CookieContainer = cookieContainer;    
        }

        internal async Task<WebcastResponse> GetDeserializedMessage(string path, Dictionary<string, object> parameters)
        {
            var get = await this.GetRequest(TikTokRequestSettings.TIKTOK_URL_WEBCAST + path, parameters);
            System.IO.Stream stream = await get.ReadAsStreamAsync();
            if ( null != OnDeserializedMessageSave)
            {
                OnDeserializedMessageSave.Invoke(this, stream);
            }   
            return Serializer.Deserialize<WebcastResponse>(stream);
        }

        internal async Task<JObject> GetJObjectFromWebcastAPI(string path, Dictionary<string, object> parameters)
        {
            var get = await this.GetRequest(TikTokRequestSettings.TIKTOK_URL_WEBCAST + path, parameters);
            return JObject.Parse(await get.ReadAsStringAsync());
        }

        internal async Task<string> GetLivestreamPage(string uniqueID)
        {
            var get = await this.GetRequest($"{TikTokRequestSettings.TIKTOK_URL_WEB}@{uniqueID}/live/");
            return await get.ReadAsStringAsync();
        }

        internal async Task<JObject> PostJObjecttToWebcastAPI(string path, Dictionary<string, object> parameters, JObject json)
        {
            var post = await this.PostRequest(TikTokRequestSettings.TIKTOK_URL_WEBCAST + path, json.ToString(Newtonsoft.Json.Formatting.None), parameters);
            return JObject.Parse(await post.ReadAsStringAsync());
        }

        private ITikTokHttpRequest BuildRequest(string url, Dictionary<string, object> parameters = null)
        {
            return new TikTokHttpRequest(url)
                .SetQueries(parameters);
        }

        private async Task<HttpContent> GetRequest(string url, Dictionary<string, object> parameters = null)
        {
            var request = this.BuildRequest(url, parameters);
            return await request.Get();
        }

        private async Task<HttpContent> PostRequest(string url, string data, Dictionary<string, object> parameters = null)
        {
            var request = this.BuildRequest(url, parameters);
            return await request.Post(new StringContent(data, Encoding.UTF8));
        }

        public async Task<System.IO.Stream> DownloadImageStreamAsync(string url)
        {

            return await new TikTokHttpRequest(url).GetStreamAsync(url);
        }
    }
}