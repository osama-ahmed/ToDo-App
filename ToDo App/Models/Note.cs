using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo_App.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string title { get; set; }

        [Required]
        public string content { get; set; }

        public DateTime date { get; set; }
    }
}