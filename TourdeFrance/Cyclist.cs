using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourdeFrance
{
    class Cyclist
    {
        //Name of participant, gender, country origin, result time, end position

        private String name;
        private String gender;
        private int country;
        private String resultTime;
        private int endPosition;




        public Cyclist(String name, String gender, int country, String result, int position)
        {
            this.name = name;
            this.gender = gender;
            this.country = country;
            this.resultTime = result;
            this.endPosition = position;
        }










    }
}
