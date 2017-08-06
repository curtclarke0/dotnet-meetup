using System;

namespace Notes.WebApp.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
    }
}