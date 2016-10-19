using System.Net;
using HWJSON.Contracts;

namespace HWJSON
{
    public class ExtractXMLFile : IFileCreator
    {
        public void ExtractFile(string url, string fileName)
        {
            WebClient myClient = new WebClient();
            myClient.DownloadFile(url, fileName);
        }
    }
}
