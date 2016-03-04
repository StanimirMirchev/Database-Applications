using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLBasicConcepts
{
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;
            foreach(XmlNode node in rootNode.ChildNodes)
            {
                Console.WriteLine("The name of album is {0}",node["name"].InnerText);
            }

        }
    }
}
