using System;
using static System.Console;
using System.Xml;

namespace ex
{
    class Tranzactie
    {
        private string[] IDTranzactie = new string[50];
        private DateTime[] dataTranzactiei = new DateTime[50];
        private decimal[] sumaTranzactiei = new decimal[50];
        private bool[] statutulTranzactiei = new bool[50];


        static void Main()
        {
            Random rand = new Random();
            Tranzactie T = new Tranzactie();

            for (int i = 0; i < 50; i++)
            {
                T.dataTranzactiei[i] = new DateTime(223, 3, 3);
            }

            for (int i = 0; i < 50; i++)
            {
                T.IDTranzactie[i] = Convert.ToString(1354165 + i);
                T.dataTranzactiei[i] = new DateTime(2020, rand.Next(1, 13), rand.Next(1, 29));
                T.sumaTranzactiei[i] = rand.Next(300, 64387);
                T.statutulTranzactiei[i] = rand.Next(2) == 0 ? false : true;
            }

            XmlTextWriter writer = new XmlTextWriter("stocare.xml", System.Text.Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument(true);

            XMLController xmlins = new XMLController();
            xmlins.Stocare(T.IDTranzactie, T.dataTranzactiei, T.sumaTranzactiei, T.statutulTranzactiei, ref writer);
            writer.Close();
        }
    }

    class XMLController
    {
        public void Stocare(string[] ID, DateTime[] data, decimal[] suma, bool[] statut, ref XmlTextWriter w)
        {
            w.WriteStartElement("Tranzactii"); // <Tranzactii>
            for (int i = 0; i < 50; i++)
            {
                w.WriteStartElement("Tranzactie"); // <Tranzactie>

                w.WriteStartElement("ID"); // <ID>
                w.WriteString(ID[i]); // continut
                w.WriteEndElement(); // </ID>

                w.WriteStartElement("date"); // <data>
                w.WriteString(Convert.ToString(data[i]));
                w.WriteEndElement(); // </data>

                w.WriteStartElement("suma"); // <suma>
                w.WriteString(Convert.ToString(suma[i]));
                w.WriteEndElement(); // </suma>

                w.WriteStartElement("statut"); // <statut>
                w.WriteString(Convert.ToString(statut[i]));
                w.WriteEndElement(); // </statut>

                w.WriteEndElement(); // </Tranzactie>
            }
            w.WriteEndElement(); // </Tranzactii>
        }
    }
}
