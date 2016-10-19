using System.Xml;
using HWJSON.Contracts;
using Newtonsoft.Json;

namespace HWJSON
{
    public class JSONParser : IParser
    {
        public string ParseXMLToJSON(string xmlAsString)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlAsString);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            return jsonText;
        }
    }
}
