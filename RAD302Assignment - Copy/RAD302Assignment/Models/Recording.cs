using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAD302Assignment.Models
{
    //Albums can have multiple bands(collaborative efforts) and bands can have multiple albums
    //For this I require a middle class called  Recording for the one to many relationship required for bands/albums
    public class Recording
    {
            public int RecordingId { get; set; }
            public int BandId { get; set; }
            public int AlbumId { get; set; }

            public virtual Band Band { get; set; }
            public virtual Album Album { get; set; }
    }
}