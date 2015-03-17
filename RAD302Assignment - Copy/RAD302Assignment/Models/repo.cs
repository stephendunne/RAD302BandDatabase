using RAD302Assignment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD302Assignment.Models
{
    public interface IMusicRepository : IDisposable
    {
        IEnumerable<Band> GetBandIds();

        Band GetBand(int id);

        dynamic GetGigAddress(int id);
    }

    public class MusicRepository : IMusicRepository
    {
        public MusicDb db = new MusicDb();

        public IEnumerable<Band> GetBandIds()
        {
            return db.Bands;
        }

        public Band GetBand(int id)
        {
            Band band = db.Bands.Find(id);
            if (band == null)
            {
                return null;
            }
            return band;
        }

        public dynamic GetGigAddress(int id)
        {
            Band band = db.Bands.Find(id);
            if (band == null)
            {
                return null;
            }
            return (new { City = band.NextGigAddress });
        }

        public void Dispose()
        {
            
        }
    }
}
