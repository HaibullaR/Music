using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Model
{
    public class RockBand
    {
        public string Name { get; set; } = "Kiss";
        public List<Album> Albums { get; set; }
        public List<Musiciant> Musicians { get; set; }
    }
}
