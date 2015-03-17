using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using RAD302Assignment.Models;
using RAD302Assignment.DAL;
using Google.YouTube;
using RAD302Assignment.ViewModels;
using Google.GData.Client;

namespace RAD302Assignment.Controllers
{
    public class BandController : ApiController
    {
        private IMusicRepository _repo;

        public BandController(IMusicRepository repo)
        {
            _repo = repo;
        }

        // GET api/Band
        public IEnumerable<Band> GetBands()
        {
            return _repo.GetBandIds();
        }

        //YOUTUBE API SET UP CODE!!

        /*
        public IEnumerable<YouTubeVideoViewModel> Index()
        {
            IList<YouTubeVideoViewModel> vm = new List<YouTubeVideoViewModel>();
            YouTubeRequestSettings settings = new YouTubeRequestSettings("API Project", "AIzaSyB3jRw7pCSLYcMUDnCN0MBb8sCb0dO6Djg");
            YouTubeRequest request = new YouTubeRequest(settings);

            Feed<Video> videoFeed = request.Get<Video>(new Uri("https://www.youtube.com/watch?v=r5OyLjBrGNU"));
            List<Video> theVideos = videoFeed.Entries.ToList();

            foreach (var item in theVideos)
            {
                YouTubeVideoViewModel thisVM = new YouTubeVideoViewModel();
                thisVM.video = item;
                vm.Add(thisVM);
            }

            var info = request;
            return vm;
        }
        */

        // GET api/Band/5
        //public Band GetBand(int id)
        //{
        //    Band band = _repo.GetGigAddress(id);
        //    if (band == null)
        //    {
        //        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
        //    }

        //    return band;
        //}



        //display a particular bands next gig location
        public dynamic GetBandGigAddress(int id)
        {
            var band = _repo.GetGigAddress(id);

            if(band == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return (band);

        }
    }
}