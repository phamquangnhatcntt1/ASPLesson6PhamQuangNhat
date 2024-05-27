using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PQNLesson6.Models;

namespace PQNLesson6.Controllers
{
    public class PQNSongController : Controller
    {
        private static List<PQNSong> PQNSongs = new List<PQNSong>()
        {
            new PQNSong{ID=115,PQNTitle="Phạm Quang Nhất",PQNAuthor="K22CNTT1",PQNArtist="Nhất Nhất",PQNYearRealese="2024"},
            new PQNSong{ID=115,PQNTitle="Love song",PQNAuthor="K22CNTT1",PQNArtist="Nhất",PQNYearRealese="2004"},

        };
        // GET: PQNSong
        public ActionResult Index()
        {
            return View(PQNSongs);
        }
        public ActionResult PqnCreate()
        {
            var pqnSong = new PQNSong();
            return View(pqnSong);

        }

    }
}