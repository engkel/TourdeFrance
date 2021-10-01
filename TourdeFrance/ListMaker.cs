using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TourdeFrance
{
    public class ListMaker
    {
        private List<Cyclist> cyclists = new List<Cyclist>();

        public void makeList()
        {
            // Loading the xml file 

            XElement root = XElement.Load(@"Cycling-Tour-De-France.xml");

            // Fetching all of the relevant data from the xml

            var allNames = from e in root.Descendants("participant") select e.Attribute("name").Value;
            var allGenders = from e in root.Descendants("participant") select e.Attribute("gender").Value;
            var allCountries = from e in root.Descendants("participant") select e.Attribute("countryFK").Value;
            var allIds = from e in root.Descendants("event_participant") select e.Attribute("id").Value;

            // iterating through the data in order to create the cyclist objects with correct parameters 

            for(int i =0; i<200; i++)
            {
                Cyclist cyclist = new Cyclist(allNames.ElementAt(i), allGenders.ElementAt(i), Int32.Parse(allCountries.ElementAt(i)), Int32.Parse(allIds.ElementAt(i)));
                
                var result = from e in root.Descendants("result") where (string)e.Attribute("result_code") == "duration" where ((int)e.Attribute("event_participantsFK") == Int32.Parse(allIds.ElementAt(i))) select e.Attribute("value");
                //cyclist.setResult(result.ElementAt(0).ToString());

                var possition = from e in root.Descendants("result") where (string)e.Attribute("result_code") == "rank" where ((int)e.Attribute("event_participantsFK") == Int32.Parse(allIds.ElementAt(i))) select e.Attribute("value");
               // cyclist.setPossition(Int32.Parse(possition.ElementAt(0).ToString()));

                cyclists.Add(cyclist);
            }



        }
        // returning the full List of cyclist
        public List<Cyclist> getList()
        {
            return cyclists;
        }

        

        public void createXML()
        {
            //Creating an xml for cyclists
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cyclist>));
            TextWriter tw = new StreamWriter(@"C:\Users\Andrej\Source\Repos\engkel\TourdeFrance\Cyclist.xml");
            serializer.Serialize(tw, cyclists);


        }

    }
}
