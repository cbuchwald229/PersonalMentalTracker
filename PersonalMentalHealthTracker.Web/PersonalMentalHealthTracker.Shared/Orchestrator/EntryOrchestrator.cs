using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using PersonalMentalHealthTracker.Domain;
using PersonalMentalHealthTracker.Domain.Entities;
using PersonalMentalHealthTracker.Shared.Orchestrator.Interfaces;
using PersonalMentalHealthTracker.Shared.ViewModels;

namespace PersonalMentalHealthTracker.Shared.Orchestrator
{
    public class EntryOrchestrator : IEntryOrchestrator
    {
        private MentalHealthContext _mentalHealthContext;

        public EntryOrchestrator()
        {
            _mentalHealthContext = new MentalHealthContext();
        }

        public async Task<int> CreateEntry(EntryViewModel entry)
        {
            _mentalHealthContext.Entries.Add(new Entry
            {
                EntryId = entry.EntryId,
                UserId = entry.UserId,
                DateOfEntry = entry.DateOfEntry,
                Journal = entry.Journal,
                Medication = entry.Medication,
                Mood = entry.Mood
            });

            return await _mentalHealthContext.SaveChangesAsync();
        }

        public async Task<List<EntryViewModel>> GetAllEntries()
        {
            var entries = await _mentalHealthContext.Entries.Select(x => new EntryViewModel
            {
                EntryId = x.EntryId,
                UserId = x.UserId,
                DateOfEntry = x.DateOfEntry,
                Journal = x.Journal,
                Medication = x.Medication,
                Mood = x.Mood
            }).ToListAsync();

            return entries;
        }
    }
}
