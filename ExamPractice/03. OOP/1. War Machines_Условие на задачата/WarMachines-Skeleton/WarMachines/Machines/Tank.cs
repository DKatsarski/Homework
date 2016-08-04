using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    

    public class Tank : Machine, ITank, IMachine
    {
       

        private const int StartingHealthPointsTank = 100;

        public Tank(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints, StartingHealthPointsTank)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }
       
        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
            else
            {
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var result = new StringBuilder();

            result.Append(baseString);
            result.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

            return result.ToString();
        }
    }
}
