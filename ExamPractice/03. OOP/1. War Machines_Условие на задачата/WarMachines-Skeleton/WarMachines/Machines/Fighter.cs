using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter, IMachine
    {
        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode) : base(name, attackPoints, defensePoints, 200)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }
  

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var result = new StringBuilder();

            result.Append(baseString);
            result.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));

            return result.ToString();
        }
    }
}
