using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Doorman
    {
        private string doormansName;

        public Doorman(string name)
        {
            this.doormansName = name;
        }


        public int Age { get; set; }

        public string Position { get; set; }

        public int YearsWorking { get; set; }

        public string Name
        {
            get
            {
                return this.doormansName;
            }
       
        }


        public string SpeakStuff()
        {
            return string.Format("{0} says 'CLose the door'", this.doormansName);
        }
    }
}
