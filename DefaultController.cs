using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.Services;
using System.Security.Permissions;
using System.Configuration;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Web.UI;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [WebMethod]
        public JsonResult GetMusic()
        {
            var names = new List<object>()
            {
                new { genre = "Hip-Hop", artist = "Travis Scott", album = "UTOPIA", year = 2023, song = "LOST FOREVER (feat. Westside Gunn)" },
                new { genre = "Progressive Rock", artist = "Pink Floyd", album = "Animals", year = 1977, song = "Pigs (Three Different Ones)" },
                new { genre = "Experimental Hip-Hop", artist = "clipping.", album = "midcity.", year = 2013, song = "story" },
                new { genre = "Alternative Rock", artist = "Weezer", album = "Weezer", year = 1994, song = "Say It Ain't So" },
                new { genre = "Pop Rock", artist = "Taylor Swift", album = "Speak Now", year = 2010, song = "Mine" },
                new { genre = "Grunge", artist = "Nirvana", album = "Bleach", year = 1989, song = "Blew" },
                new { genre = "Indie Pop", artist = "Young the Giant", album = "Mind Over Matter", year = 2014, song = "Mind Over Matter" },
                new { genre = "Alternative Hip-Hop", artist = "MF DOOM", album = "MM...FOOD", year = 2004 , song = "One Beer" },
                new { genre = "Jazz", artist = "Herbie Hancock", album = "Head Hunters", year = 1973, song = "Watermelon Man" },
                new { genre = "Indie Folk", artist = "The Microphones", album = "The Glow, Pt. 2", year = 2001, song = "Headless Horseman" },
                new { genre = "East Coast Hip-Hop", artist = "Westside Gunn", album = "10", year = 2022, song = "FlyGod Jr (feat. DJ Drama)" },
                new { genre = "Indie Rock", artist = "Panchiko", album = "D>E>A>T>H>M>E>T>A>L", year = 2000, song = "Laputa" },
                new { genre = "Hardcore Hip-Hop", artist = "Run The Jewels", album = "RTJ4", year = 2020, song = "ooh la la" },
                new { genre = "Hardcore Hip-Hop", artist = "Run The Jewels", album = "Run the Jewels 2", year = 2014, song = "Jeopardy" },
                new { genre = "Post-Rock", artist = "Swans", album = "To Be Kind", year = 2014, song = "Oxygen" },
                new { genre = "Hip-Hop", artist = "Kendrick Lamar", album = "To Pimp a Butterfly", year = 2015, song = "Wesley's Theory" },
                new { genre = "Hip-Hop", artist = "Kendrick Lamar", album = "untitled unmastered.", year = 2016, song = "untitled 6 | 06.30.2014" },
                new { genre = "Alternative Hip-Hop", artist = "Injury Reserve", album = "Floss", year = 2016, song = "Bad Boys 3" },
                new { genre = "Dance-Punk", artist = "LCD Soundsystem", album = "This Is Happening", year = 2010, song = "I Can Change" },
                new { genre = "Southern Hip-Hop", artist = "Future", album = "Monster", year = 2014, song = "Radical" },
                new { genre = "Abstract Hip-Hop", artist = "Earl Sweatshirt", album = "Some Rap Songs", year = 2018, song = "Riot!" },
                new { genre = "Abstract Hip-Hop", artist = "Jay Electronica", album = "A Written Testimony", year = 2020, song = "Ghost of Soulja Slim" },
                new { genre = "Post-Hardcore", artist = "Title Fight", album = "Shed", year = 2011, song = "Your Screen Door" },
            };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
        
}
