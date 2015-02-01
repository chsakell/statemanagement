using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StateManagement.Model
{
    [Serializable()]
    public class Entry
    {
        public string Name { get; set; }
        public DateTime EntryEnteredAt { get; set; }

        public Entry(string name, DateTime date)
        {
            Name = name;
            EntryEnteredAt = date;
        }
    }
}