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

        public string SpeakStuff()
        {
            return string.Format("{0} says 'CLose the door'", this.doormansName);
        }
    }
}
