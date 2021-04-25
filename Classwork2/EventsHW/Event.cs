using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EventsHW
{
    public class Event
    {
        public enum Priorities
        {
            Important = 0, NonImportant, LowImportand, MiddleImportant, UND
        }
        private string name = "NoName";
        public string Name { get => name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Name is null or empty");
                }
                this.name = value;
            }
        }
        private string place = "NoName";
        public string Place
        {
            get => place;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Place is null or empty");
                }
                this.place = value;
            }
        }
        private DateTime time;
        public DateTime Time
        {
            get => time; 
            set
            {
                if (value < DateTime.Now-TimeSpan.FromDays(1))
                {
                    throw new ApplicationException("Incorrect time event");
                }
                this.time = value;
            }
        }
        public Priorities Priority { get; set; }
        public Event(string name, string place,DateTime time, Priorities priority)
        {
            Name = name;
            Place = place;
            Time = time;
            Priority = priority;
        }
        public Event()
        {
            time = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Place: {Place}, Date:{Time}, Priority: {Priority.ToString()}"; 
        }

    }
}
