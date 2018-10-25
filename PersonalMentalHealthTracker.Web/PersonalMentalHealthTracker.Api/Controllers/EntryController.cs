using PersonalMentalHealthTracker.Shared.Orchestrator;
using PersonalMentalHealthTracker.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace PersonalMentalHealthTracker.Api.Controllers
{
    [Route("api/v1/entries")]
    public class EntryController : ApiController
    {
        private EntryOrchestrator _entryOrchestrator;

        public EntryController()
        {
            _entryOrchestrator = new EntryOrchestrator();
        }

        public async Task<List<EntryViewModel>> GetAllEntries()
        {
            var entries = await _entryOrchestrator.GetAllEntries();

            return entries;
        }
    }
}
