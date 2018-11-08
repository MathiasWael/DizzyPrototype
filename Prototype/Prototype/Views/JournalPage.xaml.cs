using Prototype.Models;
using Prototype.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JournalPage : ContentPage
    {
        private List<JournalEntry> _week = new List<JournalEntry>();
        private List<JournalEntry> _month = new List<JournalEntry>();
        private List<JournalEntry> _later = new List<JournalEntry>();

        public JournalPage()
        {
            InitializeComponent();

            List<JournalEntry> journalEntries = new List<JournalEntry>()
            {
                new JournalEntry(new DateTime(2018, 11, 8, 8, 15, 30), "Journal Entry 1"),
                new JournalEntry(new DateTime(2018, 11, 7, 12, 30, 45), "Journal Entry 2"),
                new JournalEntry(new DateTime(2018, 11, 7, 8, 30, 0), "Journal Entry 3"),
                new JournalEntry(new DateTime(2018, 11, 5, 11, 10, 20), "Journal Entry 4"),
                new JournalEntry(new DateTime(2018, 11, 2, 14, 45, 0), "Journal Entry 5"),
                new JournalEntry(new DateTime(2018, 11, 1, 16, 50, 40), "Journal Entry 6"),
                new JournalEntry(new DateTime(2018, 10, 31, 7, 0, 0), "Journal Entry 7"),
                new JournalEntry(new DateTime(2018, 10, 30, 9, 50, 30), "Journal Entry 8"),
                new JournalEntry(new DateTime(2018, 10, 4, 8, 15, 30), "Journal Entry 9"),
                new JournalEntry(new DateTime(2018, 10, 3, 12, 30, 45), "Journal Entry 10"),
                new JournalEntry(new DateTime(2018, 10, 2, 8, 30, 0), "Journal Entry 11"),
                new JournalEntry(new DateTime(2018, 10, 1, 11, 10, 20), "Journal Entry 12")
            };

            DateTime now = DateTime.Now;

            /*
            foreach (JournalEntry entry in journalEntries)
            {
                if (entry.Date < now.AddDays(-7)) _week.Add(entry);
                else if (entry.Date < now.AddDays(-30)) _month.Add(entry);
                else _later.Add(entry);
            }
            */

            _week.Add(journalEntries[0]);
            _week.Add(journalEntries[1]);
            _week.Add(journalEntries[2]);
            _week.Add(journalEntries[3]);

            _month.Add(journalEntries[4]);
            _month.Add(journalEntries[5]);
            _month.Add(journalEntries[6]);
            _month.Add(journalEntries[7]);

            _later.Add(journalEntries[8]);
            _later.Add(journalEntries[9]);
            _later.Add(journalEntries[10]);
            _later.Add(journalEntries[11]);

            _week.Sort((a, b) => DateTime.Compare(b.Date, a.Date));
            _month.Sort((a, b) => DateTime.Compare(b.Date, a.Date));
            _later.Sort((a, b) => DateTime.Compare(b.Date, a.Date));

            WeekList.HeightRequest = 4 * WeekList.RowHeight;
            MonthList.HeightRequest = 4 * MonthList.RowHeight;
            LaterList.HeightRequest = 4 * LaterList.RowHeight;

            WeekList.ItemsSource = _week;
            MonthList.ItemsSource = _month;
            LaterList.ItemsSource = _later;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var entry = args.SelectedItem as JournalEntry;
            if (entry == null)
                return;

            await Navigation.PushAsync(new JournalDetailPage(new JournalDetailViewModel(entry)));

            // Manually deselect item.
            WeekList.SelectedItem = null;
            MonthList.SelectedItem = null;
            LaterList.SelectedItem = null;
        }

        private async void ToolbarItem_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new JournalAddPage()));
        }
    }
}