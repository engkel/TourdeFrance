using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TourdeFrance
{
    class ListMaker
    {
        private List<Cyclist> cyclists = new List<Cyclist>();

        public void makeList()
        {
            
            
            string fileName = "Cycling-Tour-De-France.xml";
            XElement root = XElement.Load(fileName);
            var allNames = from e in root.Descendants("name") select e;

            foreach (string name in allNames)
            {
                System.Console.WriteLine("Found this pizza name " + name);
            }












        }







        public List<Cyclist> getList()
        {
            return cyclists;
        }







    }
}
