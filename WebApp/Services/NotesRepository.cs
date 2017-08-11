using Newtonsoft.Json;
using Notes.WebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Notes.WebApp.Services
{
    public class NotesRepository
    {
        readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "notes.json");

        public NotesRepository()
        {
            if (!File.Exists(path))
            {
                var emptyList = new List<Note>();
                var json = JsonConvert.SerializeObject(emptyList);

                File.WriteAllText(path, json);
            }
        }

        public IEnumerable<Note> GetAll()
        {
            string json = File.ReadAllText(path);

            var notes = JsonConvert.DeserializeObject<IEnumerable<Note>>(json);

            return notes;
        }

        public Note Get(Guid id)
        {
            var note = GetAll().FirstOrDefault(item => item.Id.Equals(id));

            return note;
        }

        public Note AddOrUpdate(Note note)
        {
            //read
            var notes = GetAll().ToList();

            //update
            if (note.Id == Guid.Empty)
            {
                note.Id = new Guid();
            }
            else
            {
                var existing = Get(note.Id);
                notes.Remove(existing);
            }
            note.Date = DateTime.Now;
            notes.Add(note);

            //write
            string json = JsonConvert.SerializeObject(notes);
            File.WriteAllText(path, json);

            return note;
        }
    }
}