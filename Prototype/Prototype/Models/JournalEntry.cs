using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models
{
    public class JournalEntry
    {
        public DateTime Date { get; set; }

        public string DateString
        {
            get
            {
                return Date.ToString();
            }
        }

        public string Content { get; set; }

        public JournalEntry(DateTime date, string content)
        {
            Date = date;
            Content = content;
        }
    }
}
