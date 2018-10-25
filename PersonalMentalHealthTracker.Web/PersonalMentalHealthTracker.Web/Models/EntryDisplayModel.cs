using System.Collections.Generic;
using PersonalMentalHealthTracker.Shared.ViewModels;

namespace PersonalMentalHealthTracker.Web.Models
{
    public class EntryDisplayModel
    {
        public List<EntryViewModel> Entries { get; set; }
    }
}