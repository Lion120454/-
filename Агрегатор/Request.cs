using System;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp.Html.Parser;
using Leaf.xNet;

namespace Агрегатор
{
    class Request
    {
        public static string GetRequest(string Link)
        {
            HttpRequest request = new HttpRequest();
            request.AddHeader("Accept", "5");
            request.KeepAlive = true;
            request.UserAgent = Http.OperaUserAgent();
            string response = request.Get(Link).ToString();
            return response;
        }

        public static string Parser(string Response)
        {
            HtmlParser hp = new HtmlParser();
            var Doc = hp.ParseDocument(Response);
            string CountSelectCity = Doc.QuerySelector("div.items-items-kAJAg").ChildElementCount.ToString();//Колличесво найденных товаро Авито
            string Price = Doc.QuerySelector("div.items-items-kAJAg").InnerHtml;//
            return CountSelectCity;
        }
        
    }
}
