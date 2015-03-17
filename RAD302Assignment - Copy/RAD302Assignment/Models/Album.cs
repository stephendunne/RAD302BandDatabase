using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RAD302Assignment.Models
{
    //Album class for the MusicDb

    public class Album
    {
        public int Id { get; set; }
        [DisplayName("Album Name")]
        public string Name { get; set; }
        [DisplayName("Top Single")]
        public string Single { get; set; }
        [DisplayName("Sales")]
        public int Sales { get; set; }
        [DisplayName("Bands")]
        public virtual ICollection<Recording> AlbumsBand { get; set; }
    }
}