using NewMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewMusic.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var genres = new List<Genre>
    {
        new Genre { GenreName = "迪斯科"},
        new Genre { GenreName = "爵士"},
        new Genre { GenreName = "摇滚"},
        new Genre { GenreName = "其他"}
    };
            return View(genres);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { GenreName = genre };
            return View(genreModel);
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}