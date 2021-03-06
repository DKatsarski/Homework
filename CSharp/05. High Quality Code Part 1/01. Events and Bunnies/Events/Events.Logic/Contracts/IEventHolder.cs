﻿namespace Events.Logic.Contracts
{
    using System;

    public interface IEventHolder
    {
        void AddEvent(DateTime date, string title, string location);

        void DeleteEvents(string titleToDelete);

        void ListEvents(DateTime date, int count);
    }
}
