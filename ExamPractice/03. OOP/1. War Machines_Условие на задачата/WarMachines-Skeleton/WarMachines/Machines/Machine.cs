using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Common;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {

        private string name;
        private IPilot pilot;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints, double healthpoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthpoints;
            this.targets = new List<string>();

        }

        public double AttackPoints { get; protected set; }
     

        public double DefensePoints { get; protected set; }
    

        public double HealthPoints { get; set; }
   
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "OMG CANNOT BE WITHOUT LETTERS!");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                Validator.CheckIfNull(value, "Pilot cannot be null!");
                this.pilot = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            Validator.CheckIfStringIsNullOrEmpty(target, "blaabla don't do this!");

            this.targets.Add(target);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            var targets = this.targets.Count > 0 ? string.Join(", ", this.targets) : "None";

            result.AppendLine(string.Format("- {0}", this.Name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            result.AppendLine(string.Format(" *Defence: {0}", this.DefensePoints));
            result.AppendLine(string.Format(" *Targets: {0}", targets));

            return result.ToString();

        }
    }
}
