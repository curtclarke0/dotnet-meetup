using Notes.WebApp.Models;
using System;
using System.Collections.Generic;

namespace Notes.WebApp.Services
{
    public interface INotesRepository
    {
        void Load();
        void Save();

        IEnumerable<Note> GetAll();
        Note Get(Guid id);
        Note AddOrUpdate(Note note);
        void Delete(Note note);
    }
}
