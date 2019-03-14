using Bazik.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bazik
{
    public  class StarterOfTheApp
    {
        private IWriter writer;

        public StarterOfTheApp()
        {
            this.writer = new Writer();
        }

        public  void Start()
        {

        }
    }
}
