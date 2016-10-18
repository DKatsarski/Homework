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

            AlbumCounter(rootNode);
            DeleteAlbumsWithHighPrice(rootNode);
            ExtractSongNames();


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

        private static void ExtractSongNames()
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
