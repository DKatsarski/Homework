using System;
using System.IO;
using System.Linq;
using HWJSON.Printers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HWJSON
{
    public class StartUp
    {
        static void Main()
        {
            string url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string fileName = "../../youtubeRSS.xml";

            ExtractXMLFile xmlFileToBeExtracted = new ExtractXMLFile();
            xmlFileToBeExtracted.ExtractFile(url, fileName);

            // Parse XML To String
            string xmlAsString = File.ReadAllText(fileName);
            var parseXMLToJSON = new JSONParser();
            var jsonFile = parseXMLToJSON.ParseXMLToJSON(xmlAsString);

            var parsedJson = JObject.Parse(jsonFile);

            // Using LINQ-to-JSON select all video titles and print them on the console
            var titles = parsedJson["feed"]["entry"]
                .Select(x => x["title"]);

            var printer = new JsonPrinter();
            printer.Print(titles);

            var pocoObject = JsonConvert.DeserializeObject(jsonFile);
            Console.WriteLine(pocoObject);
        }
    }
}

