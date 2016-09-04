namespace ControlFlowAndStuff
{
    internal class Potato : Vegetable
    {
        int cookingTimeNeeded;

        public Potato()
        {
            this.cookingTimeNeeded = 150;
        }

        public string Type { get; set; }

        public int CookingTimeNeeded
        {
            get
            {
                return cookingTimeNeeded;
            }
            private set
            {
                value = 150;
            }
        }

    }
}