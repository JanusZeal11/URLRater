using Sunlight_WebDev_Evaulation__URLRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace Sunlight_WebDev_Evaulation__URLRater.Controllers
{
    public class URLController : ApiController
    {
        List<URL> urls = new List<URL>();

        public URLController()
        {
            String fileLocation = System.Web.HttpContext.Current.Request.MapPath(@"\App_Data\generatedURL.xml");
            XDocument xdoc = XDocument.Load(fileLocation);

            foreach (XElement element in xdoc.Descendants(XName.Get("url")))
            {
                urls.Add(new URL { Id = urls.Count + 1, Url = element.Value, Votes = 0 });
            }
        }

        public IEnumerable<URL> GetAllURLs()
        {
            return urls;
        }
    }
}
