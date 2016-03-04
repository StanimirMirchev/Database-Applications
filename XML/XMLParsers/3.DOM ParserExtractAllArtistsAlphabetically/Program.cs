using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DOM_ParserExtractAllArtistsAlphabetically
{
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;
            SortedSet<string> artists = new SortedSet<string>();
            foreach (XmlNode node in rootNode.ChildNodes) 
            {
                artists.Add(node["artist"].InnerText);
            }
            Console.WriteLine("-- Artists in alphabetical order --");
            foreach (var artist in artists) 
            {
                Console.WriteLine(artist);
            }
        }
    }
}
