using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DOMParserExtractArtistsAndNumber
{
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;
            Dictionary<string, int> artistsAndNumberOfAlbum = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                string artistName = node["artist"].InnerText;
                if (artistsAndNumberOfAlbum.ContainsKey(artistName))
                {
                    artistsAndNumberOfAlbum[artistName] = artistsAndNumberOfAlbum[artistName] + 1;
                }
                else
                {
                    artistsAndNumberOfAlbum[artistName] = 1;
                }
            }

            foreach (var i in artistsAndNumberOfAlbum)
            {
                Console.WriteLine("{0} : {1}", i.Key, i.Value);
            }
        }
    }
}
