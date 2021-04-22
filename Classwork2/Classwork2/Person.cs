using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork2
{
    class Person
    {
        public string Name { get; set; } = "NoName";
        public DateTime Birth { get; set; }
        public override string ToString()
        {
            return $"{Name}\t Date:{Birth.ToShortDateString()}";
        }
    }
}
