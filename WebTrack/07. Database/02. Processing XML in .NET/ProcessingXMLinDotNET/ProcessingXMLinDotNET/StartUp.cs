using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ProcessingXMLinDotNET
{
    using System;
    using System.Collections;
    using System.Xml;

    public class StartUp
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../Catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;

            //AlbumCounter(rootNode);
            //DeleteAlbumsWithHighPrice(rootNode);
            //ExtractSongTitles();

            //Write a program, which(using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, in which stores in appropriate way the names of all albums and their authors.



            string filename = "../../Catalogue.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");



            XDocument xmlDoc = XDocument.Load("../../Catalogue.xml");
            var albums = xmlDoc.Descendants("album")
                .OrderByDescending(album => album.Element("name").Value)
                .Select(x => new
                {
                    Name = x.Element("name").Value + " "
                })
                .Take(2);

            foreach (var r in albums)
            {
                Console.WriteLine(r.Name);
            }
            



            //using (XmlReader reader = XmlReader.Create("../../Catalogue.xml"))
            //{
            //    while (reader.Read())
            //    {
            //        if (reader.Name == "title")
            //        {
            //            Console.WriteLine(reader.ReadString());
            //        }
            //    }
            //}










        }


        private static void WriteBook(XmlWriter writer, string title, string author, string isbn)
        {
            writer.WriteStartElement("book");
            writer.WriteElementString("title", title);
            writer.WriteElementString("author", author);
            writer.WriteElementString("isbn", isbn);
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
