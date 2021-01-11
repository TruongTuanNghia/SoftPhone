using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SupportSoftPhone.Helpers
{
    public class WebServices
    {
        private string RequestUrl { get; set; }
        private string RequestPostData { get; set; }
        public WebServices(string commandUri, string jsonPostData)
        {
            RequestUrl = $"{Constants.SERVICE_URL}/{commandUri}";
            if (!string.IsNullOrEmpty(jsonPostData))
                RequestPostData = jsonPostData;
        }
        private WebClient CreateWebClient()
        {
            var webClient = new WebClient();
            webClient.Headers.Add("Cache-Control", "no-cache");
            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Encoding = System.Text.Encoding.UTF8;
            webClient.Headers.Add("X-ApiKey", Constants.SERVICE_AUTH_KEY);
            return webClient;
        }
        public string Get()
        {
            using (var client = CreateWebClient())
            {
                var result = client.DownloadString(RequestUrl);
                return result;
            }
        }
        public string Post()
        {
            using (var client = CreateWebClient())
            {
                var result = client.UploadString(RequestUrl, "POST", RequestPostData);
                return result;
            }
        }
    }
}
