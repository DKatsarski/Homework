using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Common;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Cannot be null!");
                this.name = value;
            }
        }
   

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNull(machine, "Null machines cannot be added to file!");

            this.machines.Add(machine);

            
        }

        public string Report()
        {
            var sortedMachines =
                 this.machines.OrderBy(x => x.HealthPoints)
                 .ThenBy(x => x.Name);

            var noMachineMaybe =
                this.machines.Count > 0 ? this.machines.Count.ToString() : "no";

            var pluralMaybe = this.machines.Count == 1 ? "machine" : "machines";


            var restlt = new StringBuilder();
            restlt.AppendLine(string.Format("{0} - {1} {2}", this.Name, noMachineMaybe, pluralMaybe));

            foreach (var machine in sortedMachines)
            {
                restlt.AppendLine(machines.ToString());
            }

            return restlt.ToString().Trim();

        }
    }
}
