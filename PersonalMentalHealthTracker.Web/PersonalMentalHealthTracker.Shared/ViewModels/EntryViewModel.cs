using System;

namespace PersonalMentalHealthTracker.Shared.ViewModels
{
    public class EntryViewModel
    {
        public Guid EntryId { get; set; }
        public string UserId { get; set; }
        public DateTime? DateOfEntry { get; set; }
        public string DateOfEntryString => DateOfEntry.ToString();
        public string Journal { get; set; }
        public string Medication { get; set; }
        public int Mood { get; set; }
        public string MoodString => Mood.ToString();
    }
}
