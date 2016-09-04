using System.Collections.Generic;

namespace ControlFlowAndStuff
{
    internal class Bowl
    {
        ICollection<Vegetable> content;

        public Bowl()
        {
            this.content = new List<Vegetable>();
        }

        public int SizeInMl { get; set; }

        public void Add(Vegetable vegetable)
        {
            content.Add(vegetable);
        }
    }
}
