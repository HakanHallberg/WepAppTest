﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string SongName { get; set; }

        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}
