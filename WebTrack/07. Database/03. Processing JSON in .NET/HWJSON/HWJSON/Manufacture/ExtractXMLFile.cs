using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HWJSON.Contracts;

namespace HWJSON
{
    public class FileCreator : IFileCreator
    {
        public void ExtractFile(string url, string fileName)
        {
            WebClient myClient = new WebClient();
            myClient.DownloadFile(url, fileName);
        }
    }
}
