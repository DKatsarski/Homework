namespace Minesweeper
{
    // TODO: Maybe change name to Ranglist, but if this would be the case, better input some more methods here
    public class PointsHolder
    {
        string name;
        int points;

        public PointsHolder()
        {
        }

        public PointsHolder(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }
    }
}
