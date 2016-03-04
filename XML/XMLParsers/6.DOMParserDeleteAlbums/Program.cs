using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DOMParserDeleteAlbums
{
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            Console.WriteLine("XML Document loaded!");
            Console.WriteLine();

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode albumNode in rootNode.ChildNodes)
            {
                if (Decimal.Parse(albumNode["price"].InnerText) < 20)
                {
                    albumNode.ParentNode.RemoveChild(albumNode);
                }
            }
            Console.WriteLine("Document has been modified.");

            doc.Save("../../../cheap-albums-catalog.xml");

            Console.WriteLine("Document has been saved.");
                
        }
    }
}
