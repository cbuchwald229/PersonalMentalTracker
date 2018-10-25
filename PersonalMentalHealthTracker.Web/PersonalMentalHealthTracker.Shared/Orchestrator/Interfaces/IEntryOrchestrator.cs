using PersonalMentalHealthTracker.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalMentalHealthTracker.Shared.Orchestrator.Interfaces
{
    interface IEntryOrchestrator
    {
        Task<List<EntryViewModel>> GetAllEntries();
        Task<int> CreateEntry(EntryViewModel entry);
    }
}
