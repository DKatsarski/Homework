using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HWJSON
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var fileName = "youtubeRSS";
            WebClient myClient = new WebClient();
            myClient.DownloadFile(url, fileName);


        }
    }
}
