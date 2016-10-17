using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProcessingXMLinDotNET
{
    public class StartUp
    {
        static void Main()
        {
            // Write program that extracts all different artists which are found in the catalog.xml.
            // For each author you should print the number of albums in the catalogue.
            // Use the DOM parser and a hash - table.

            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\Google Drive\Programirane\TELERIK Academy\Homework\WebTrack\07. Database\02. Processing XML in .NET\ProcessingXMLinDotNET\ProcessingXMLinDotNET\catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;
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
    }
}
