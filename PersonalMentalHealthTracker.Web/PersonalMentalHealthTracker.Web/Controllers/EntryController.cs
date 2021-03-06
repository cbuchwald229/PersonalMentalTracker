﻿using PersonalMentalHealthTracker.Shared.Orchestrator;
using PersonalMentalHealthTracker.Shared.ViewModels;
using PersonalMentalHealthTracker.Web.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PersonalMentalHealthTracker.Web.Controllers
{
    public class EntryController : Controller
    {
        private EntryOrchestrator _entryOrchestrator = new EntryOrchestrator();
        // GET: Entry
        public async Task<ActionResult> Index()
        {
            var entryDisplayModel = new EntryDisplayModel
            {
                Entries = await _entryOrchestrator.GetAllEntries()
            };
            return View(entryDisplayModel);
        }

        public async Task<ActionResult> Create(CreateEntryModel entry)
        {
            if (string.IsNullOrWhiteSpace(entry.UserId))
            return View();

            var updateCount = await _entryOrchestrator.CreateEntry(new EntryViewModel
            {
                EntryId = Guid.NewGuid(),
                UserId = entry.UserId,
                DateOfEntry = entry.DateOfEntry,
                Journal = entry.Journal,
                Medication = entry.Medication,
                Mood = entry.Mood
            });

            return View();
        }
    }
}