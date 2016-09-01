namespace Minesweeper
{
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
