using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourdeFrance
{
    public class Cyclist
    {
        //Name of participant, gender, country origin, result time, end position

        private String name;
        private String gender;
        private int country;
        private int participantId;

        private String resultTime;
        private int endPosition;


        public Cyclist()
        {

        }

        public Cyclist(String name, String gender, int country,int id)
        {
            this.name = name;
            this.gender = gender;
            this.country = country;
            this.participantId = id;

        }


        public void setResult(String result)
        {
            this.resultTime = result;
        }


        public void setPossition (int possition)
        {
            this.endPosition = possition;
        }




    }
}
