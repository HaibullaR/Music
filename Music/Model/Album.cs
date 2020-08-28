using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Model
{
    public class Album
    {
        public string Name { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Description { get; set; } = "the best album";
        public List<Song> Songs { get; set; }

        public Album()
        {
            Songs = new List<Song>();
        }
    }
}
