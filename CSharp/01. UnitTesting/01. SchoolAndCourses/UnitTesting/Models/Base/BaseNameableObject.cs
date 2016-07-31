using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Contracts;
using UnitTesting.Utils;

namespace UnitTesting.Models.Base
{
    public class BaseNameableObject : INameable
    {
        private string name;

        public BaseNameableObject(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (Validator.CheckIfStringIsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }
    }
}
