using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HWJSON.Printers;
using Newtonsoft.Json.Linq;

namespace HWJSON
{
    public class StartUp
    {
        static void Main()
        {
            string url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string fileName = "../../youtubeRSS.xml";

            //ExtractXMLFile xmlFileToBeExtracted = new ExtractXMLFile();
            //xmlFileToBeExtracted.ExtractFile(url, fileName);

            // Parse XML To String
            string xmlAsString = File.ReadAllText(fileName);
            var parseXMLToJSON = new JSONParser();
            var jsonFile = parseXMLToJSON.ParseXMLToJSON(xmlAsString);

            var parsedJson = JObject.Parse(jsonFile);

            var titles = parsedJson["feed"]["entry"]
                .Select(x => x["title"]);

            var printer = new JsonPrinter();

            printer.Print(titles);


            //Console.WriteLine(wtf);


        }
    }
}

