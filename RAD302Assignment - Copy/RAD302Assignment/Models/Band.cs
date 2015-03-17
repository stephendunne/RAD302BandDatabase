using Google.YouTube;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RAD302Assignment.Models
{
    //Band class for the MusicDb

    //Bands can have a genre
    public enum Genre
    {
        Pop, Rock, Punk, Metal, Electronica
    }
    
    public class Band
    {
        public int Id { get; set; }
        [DisplayName("Band Name")]
        public string Name { get; set; }
        [DisplayName("Lead Singer")]
        public string Singer { get; set; }
        [DisplayName("Genre")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Genre MusicGenre { get; set; }

        [DisplayName("Next Gig Address")]
        public String NextGigAddress { get; set; }

        [DisplayName("Albums")]
        public virtual ICollection<Recording> BandAlbums { get; set; }

        //public Video video { get; set; }
        
    }
}