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
        }

        private static void AlbumCounter(XmlNode rootNode)
        {
            // Write program that extracts all different artists which are found in the catalog.xml.
            // For each author you should print the number of albums in the catalogue.
            // Use the DOM parser and a hash - table.


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
                    Console.WriteLine(rootNode.FirstChild.Name);
                    // TODO: Delete the album from the file.
                }
            }
        }
    }
}
