using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models.Music
{
    public class Track
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String ArtistName { get; set; }
        public String Url { get; set; }
    }
}