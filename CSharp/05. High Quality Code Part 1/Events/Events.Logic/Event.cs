namespace Events.Logic
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int toDate = this.date.CompareTo(other.date);
            int toTitle = this.title.CompareTo(other.title);
            int toLocation = this.location.CompareTo(other.location);

            if (toDate == 0)
            {
                if (toTitle == 0)
                { 
                    return toLocation;
                }
                else
                {
                    return toTitle;
                }
            }
            else
            {
                return toDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
