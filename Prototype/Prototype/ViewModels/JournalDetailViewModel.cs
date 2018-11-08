using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ViewModels
{
    public class JournalDetailViewModel : BaseViewModel
    {
        public JournalEntry JournalEntry { get; set; }
        public JournalDetailViewModel(JournalEntry entry = null)
        {
            Title = entry?.Date.ToString();
            JournalEntry = entry;
        }
    }
}
