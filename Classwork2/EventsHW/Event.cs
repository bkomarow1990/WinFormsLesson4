using System;
using System.Collections.Generic;
using System.Text;

namespace EventsHW
{
    class Event
    {
        public enum Priorities
        {
            Important = 0, NonImportant, LowImportand, MiddleImportant, UND
        }
        public string Name { get; set; } = "NoName";
        public string Place { get; set; } = "NoPlace";
        public DateTime Time { get; set; }
        public Priorities Priority { get; set; }
        public Event(string name, DateTime time, Priorities priority)
        {
            Name = name;
            Time = time;
            Priority = priority;
        }

    }
}
