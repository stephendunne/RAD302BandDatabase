using RAD302Assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RAD302Assignment.DAL
{
    internal class MusicDbInitializer : DropCreateDatabaseAlways<MusicDb>
    {
        protected override void Seed(MusicDb context)
        {
            var bands = new List<Band>
            {
                new Band{
                    Name = "Blink 182",
                    Singer = "Mark Hoppus",
                    MusicGenre = Genre.Punk,
                    NextGigAddress = "Montreal"
                },

                new Band{
                    Name = "Beatles",
                    Singer = "John Lennon",
                    MusicGenre = Genre.Pop,
                    NextGigAddress = "London"
                },
            
                new Band{
                    Name = "Metallica",
                    Singer = "James Hetfield",
                    MusicGenre = Genre.Metal,
                    NextGigAddress = "New York"
                },

                new Band{
                    Name = "Queen",
                    Singer = "Freddie Mercury",
                    MusicGenre = Genre.Rock,
                    NextGigAddress = "Paris"
                },

                new Band{
                    Name = "Daft Punk",
                    Singer = "Thomas Bangalter",
                    MusicGenre = Genre.Electronica,
                    NextGigAddress = "Los Angeles"
                }
            };

            bands.ForEach(b => context.Bands.Add(b));
            context.SaveChanges();

            var albums = new List<Album>
            {
                new Album
                {
                    Name = "Dude Ranch",
                    Single = "Josie",
                    Sales = 100000
                },

                new Album
                {
                    Name = "Neighborhoods",
                    Single = "After Midnight",
                    Sales = 320000
                },

                new Album
                {
                    Name = "Sgt. Peppers Lonely Hearts Club",
                    Single = "Lucy In The Sky With Diamonds",
                    Sales = 1100000
                },

                new Album
                {
                    Name = "Abbey Road",
                    Single = "Come Together",
                    Sales = 1050000
                },

                new Album
                {
                    Name = "Metallica (Album)",
                    Single = "Enter Sandman",
                    Sales = 6000000
                },

                new Album
                {
                    Name = "Ride The Lightening",
                    Single = "Fade To Black",
                    Sales = 4300000
                },

                new Album
                {
                    Name = "A Night At The Opera",
                    Single = "Bohemian Rhapsody",
                    Sales = 1600000
                },

                new Album
                {
                    Name = "News Of The World",
                    Single = "We Will Rock You",
                    Sales = 1300000
                },
            
                new Album
                {
                    Name = "Random Access Memory",
                    Single = "Get Lucky",
                    Sales = 700000
                },

                new Album
                {
                    Name = "Discovery",
                    Single = "One More Time",
                    Sales = 650000
                }
            };

            albums.ForEach(a => context.Albums.Add(a));
            context.SaveChanges();

            var recordings = new List<Recording>
            {
                new Recording{BandId=1,AlbumId=1},
                new Recording{BandId=1,AlbumId=2},
                new Recording{BandId=2,AlbumId=3},
                new Recording{BandId=2,AlbumId=4},
                new Recording{BandId=3,AlbumId=5},
                new Recording{BandId=3,AlbumId=6},
                new Recording{BandId=4,AlbumId=7},
                new Recording{BandId=4,AlbumId=8},
                new Recording{BandId=5,AlbumId=9},
                new Recording{BandId=5,AlbumId=10}
            };

            
            recordings.ForEach(r => context.Recordings.Add(r));
            context.SaveChanges();
        }
    }

    public class MusicDb : DbContext
    {
        public MusicDb()
            : base("MusicDb")
        {
        }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Recording> Recordings { get; set; }
        public DbSet<Album> Albums { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}