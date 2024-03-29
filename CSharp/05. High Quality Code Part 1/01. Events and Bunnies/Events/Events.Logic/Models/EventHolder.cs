﻿namespace Events.Logic
{
    using Contracts;
    using System;
    using Wintellect.PowerCollections;

    public class EventHolder : IEventHolder
    {
        private MultiDictionary<string, Event> toTitle = new MultiDictionary<string, Event>(true);

        private OrderedBag<Event> toDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.toTitle.Add(title.ToLower(), newEvent);
            this.toDate.Add(newEvent);
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.toTitle[title])
            {
                removed++;
                this.toDate.Remove(eventToRemove);
            }

            this.toTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.toDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
