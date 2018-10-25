using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalMentalHealthTracker.Web.Models
{
    public class CreateEntryModel
    {
        public Guid EntryId { get; set; }
        public string UserId { get; set; }
        public DateTime? DateOfEntry { get; set; }
        public string Journal { get; set; }
        public string Medication { get; set; }
        public int Mood { get; set; }
    }
}