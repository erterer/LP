using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace LifePerformance___Sven_Nottelman.Models
{
    public class Bezoek
    {
        //Bestandspad waar de .xml file naar wordt weggeschreven
        private string bestandsPad;

        //Lijst met waarnemingen
        public List<Waarneming> waarnemingen { get; set; }

        //Aanvangst van het bezoek, datum en tijd
        public DateTime StartTijd { get; set; }

        //Einddtijd van het bezoek, datum en tijd
        public DateTime EindTijd { get; set; }

        /// <summary>
        /// Zetten van de tijden van het bezoek
        /// </summary>
        /// <param name="datum">Datum van het bezoek</param>
        /// <param name="startTijd">Aanvangst van het bezoek</param>
        /// <param name="eindTijd">Eindtijd van het bezoek</param>
        public Bezoek(DateTime startTijd, DateTime eindTijd)
        {
            StartTijd = startTijd;
            EindTijd = eindTijd;
            waarnemingen = new List<Waarneming>();
        }

        /// <summary>
        /// Opslaan van de waarnemingen van een bezoek in een .xml file
        /// </summary>
        /// <param name="bezoek">Het bezoek dat moet worden opgeslagen</param>
        /// <returns>Geeft true terug als de methode succesvol is uitgevoerd</returns>
        public bool SaveToXML(Bezoek bezoek)
        {
            //Kiezen van de locatie
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bestandsPad = fbd.SelectedPath;
                bestandsPad = bestandsPad + @"\Dieren " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".XML";
            }

            //Aanmaken XML writer
            XmlWriter xmlWriter = XmlWriter.Create(bestandsPad);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Waarnemingen");

            //Vullen van het bestand
            foreach (Waarneming waarneming in bezoek.waarnemingen)
            {
                try
                {
                    xmlWriter.WriteStartElement("Waarneming");

                    xmlWriter.WriteStartElement("Type_waarneming");
                    xmlWriter.WriteString(waarneming.Soort.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Dier");

                    xmlWriter.WriteStartElement("Naam");
                    xmlWriter.WriteString(waarneming.Dier.Naam);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Afkorting");
                    xmlWriter.WriteString(waarneming.Dier.Afkorting);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Tijdstip");
                    xmlWriter.WriteString(waarneming.Tijdstip.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("AantalPunten");
                    xmlWriter.WriteString(waarneming.Punten.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                }
                catch (Exception e)
                {
                    throw new Exception(e.ToString());
                }
            }
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            return true;
        }

        /// <summary>
        /// Ophalen van de eerder opgeslagen .xml file met de waarnemingen en opslaan in de database
        /// </summary>
        /// <param name="bezoek">Het bezoek wat moet worden opgeslagen</param>
        /// <returns>Geeft true terug als de methode succesvol is uitgevoerd</returns>
        public bool SaveToDatabase(Bezoek bezoek)
        {
            throw new NotImplementedException();
            //Hier moet de XML file worden uitgelezen
            //Dit kan met de dataserializer, hiermee wordt er voor ieder xml blok een property gevuld van de klasse waardoor er een object ontstaat
            //Als alle objecten in een lijst zitten kan deze lijst worden weggeschreven naar de database.
            //Dit gebeurd via een insert query in de repository. Als alles is weggeschreven en de database methode true heeft teruggegeven dan kan de xml
            //file worden verwijderd.
        }
    }
}
