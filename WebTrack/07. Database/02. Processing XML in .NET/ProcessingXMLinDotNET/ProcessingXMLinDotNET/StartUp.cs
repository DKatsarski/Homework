using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ProcessingXMLinDotNET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml;

    public class StartUp
    {
        static void Main()
        {
          
            XmlDocument doc = new XmlDocument();
            doc.Load("../../Catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;

            AlbumCounter(rootNode);
            DeleteAlbumsWithHighPrice(rootNode);
            ExtractSongTitles();

            
            //Write a program, which(using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, in which stores in appropriate way the names of all albums and their authors.






            //XDocument xmlDoc = XDocument.Load("../../Catalogue.xml");
            //var albums = xmlDoc.Descendants("album")
            //    .OrderByDescending(album => album.Element("name").Value)
            //    .Select(x => new
            //    {
            //        Name = x.Element("name").Value + " "
            //    })
            //    .Take(2);



            //Console.WriteLine("Document {0} created.", fileName);




            StringBuilder sbForAlbumsNames = new StringBuilder();
            StringBuilder sbForArtistsNames = new StringBuilder();


            using (XmlReader reader = XmlReader.Create("../../Catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.Name == "name")
                    {
                        sbForAlbumsNames.AppendLine(reader.ReadString());
                    }

                    if (reader.Name == "artist")
                    {
                        sbForArtistsNames.AppendLine(reader.ReadString());
                    }
                }
            }



            List<string> albumsNames = new List<string>(sbForAlbumsNames.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

            albumsNames.Sort();

            //sbForAlbumsNames = new StringBuilder(string.Join("\r\n", albumsNames.ToArray()));

            
            List<string> artistsNames = new List<string>(sbForArtistsNames.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

            artistsNames.Sort();

            //sbForArtistsNames = new StringBuilder(string.Join("\r\n", artistsNames.ToArray()));



            string fileName = "../../album.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                
                writer.WriteStartDocument();

                for (int i = 0; i < albumsNames.Count; i++)
                {

                }

                writer.WriteStartElement("library");
            //    writer.WriteAttributeString("name", "My Library");
            //    WriteAlbum(writer, "Code Complete",
            //        "Steve McConnell", "155-615-484-4");
            //    WriteAlbum(writer, "Въведение в програмирането със C#",
            //        "Светлин Наков и колектив", "954-775-305-3");
            //    WriteAlbum(writer, "Writing Solid Code",
            //        "Steve Maguire", "155-615-551-4");
            //    writer.WriteEndDocument();
            }






        }

        // TODO: Extract method.
        //private static void SortStringBuilders()
        //{

        //}

        private static void WriteAlbum(XmlWriter writer, string artist, string year, string producer, string title, string duration)
        {
            writer.WriteStartElement("name");
            writer.WriteElementString("artist", artist);
            writer.WriteElementString("year", year);
            writer.WriteElementString("producer", producer);
              writer.WriteStartElement("songs");
                 writer.WriteElementString("title", title);
                 writer.WriteElementString("duration", duration);
              writer.WriteEndElement();
            writer.WriteEndElement();
        }

        private static void AlbumCounter(XmlNode rootNode)
        {
            var listOfArtists = new Hashtable();
            var key = 1;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                listOfArtists.Add(key++, node["artist"].InnerText);
            }

            var numberOfAlbums = 0;

            for (int i = 1; i < listOfArtists.Count; i++)
            {
                numberOfAlbums++;

                if (listOfArtists[i].ToString() != listOfArtists[i + 1].ToString())
                {
                    Console.WriteLine("{0} has {1} albums", listOfArtists[i], numberOfAlbums);

                    numberOfAlbums = 0;

                    if (i + 1 == listOfArtists.Count)
                    {
                        numberOfAlbums++;
                        Console.WriteLine("{0} has {1} albums", listOfArtists[i + 1], numberOfAlbums);
                    }
                }
            }
        }

        private static void DeleteAlbumsWithHighPrice(XmlNode rootNode)
        {
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var priceOfTheAlbum = double.Parse(node["price"].InnerText);

                if (priceOfTheAlbum > 20)
                {
                    rootNode.FirstChild.RemoveAll();
                }
            }
        }

        private static void ExtractSongTitles()
        {
            using (XmlReader reader = XmlReader.Create("../../Catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadString());
                    }
                }
            }
        }
    }
}
