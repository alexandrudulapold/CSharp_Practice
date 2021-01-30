using System;
using System.Xml;
using static System.Console;


namespace XML
{
    class CreareXML
    {
        static void Main()
        {
            XmlTextWriter writer = new XmlTextWriter("exemplu.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartElement("UtilizatoriDatabase"); //<UtilizatoriDatabase>

            writer.WriteStartElement("Utilizator"); //<Utilizator>
            writer.WriteStartElement("Utilizator_ID"); //<Utilizator_ID>
            writer.WriteString("123werty");  //continut
            writer.WriteEndElement(); //</Utilizator_ID>
            writer.WriteStartElement("Utilizator_password"); //<Utilizator_password>
            writer.WriteString("aaa");  //continut
            writer.WriteEndElement(); //</Utilizator_password>
            writer.WriteEndElement(); //</Utilizator>

            writer.WriteStartElement("Utilizator"); //<Utilizator>
            writer.WriteStartElement("Utilizator_ID"); //<Utilizator_ID>
            writer.WriteString("2563wertqy");  //continut
            writer.WriteEndElement(); //</Utilizator_ID>
            writer.WriteStartElement("Utilizator_password"); //<Utilizator_password>
            writer.WriteString("bbb");  //continut
            writer.WriteEndElement(); //</Utilizator_password>
            writer.WriteEndElement(); //</Utilizator>

            writer.WriteEndElement(); //</UtilizatoriDatabase>
            writer.WriteEndDocument();
            writer.Close();

            Console.Write("Fisier XML creat cu succes");
        }
    }
}
