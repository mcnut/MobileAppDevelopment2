using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_View_Pubs.Models
{
    public class Pub
    {
        public int PubId { get; set; }
        public string PubName { get; set; }
        public string PubComment { get; set; }
        public string PubImage { get; set; }

    }

    public class PubManager
    {
        public static List<Pub> GetPubs()
        {
            var pubs = new List<Pub>();

            pubs.Add(new Models.Pub { PubId = 1, PubName = "Alice's", PubComment = "At the bridge", PubImage = "Assets/alices.png" });
            pubs.Add(new Models.Pub { PubId = 2, PubName = "Amethyst", PubComment = "Newly Reopened", PubImage = "Assets/amethyst.png" });
            pubs.Add(new Models.Pub { PubId = 3, PubName = "Gielty's", PubComment = "Last chance saloon", PubImage = "Assets/gieltys.png" });
            pubs.Add(new Models.Pub { PubId = 4, PubName = "Pattens", PubComment = "Fancy a game of darts?", PubImage = "Assets/johnnies.png" });
            pubs.Add(new Models.Pub { PubId = 5, PubName = "McLoughlin's", PubComment = "A Proper Pint!!!", PubImage = "Assets/josies.png" });
            pubs.Add(new Models.Pub { PubId = 6, PubName = "The Pub", PubComment = "Lourdie's", PubImage = "Assets/lourdies.png" });
            pubs.Add(new Models.Pub { PubId = 7, PubName = "Lynotts", PubComment = "Céol, craic agus caint", PubImage = "Assets/lynotts.png" });
            pubs.Add(new Models.Pub { PubId = 8, PubName = "Lavelle's", PubComment = "Mickey's", PubImage = "Assets/mickeys.png" });
            pubs.Add(new Models.Pub { PubId = 9, PubName = "Pure Magic", PubComment = "Don't drink and Kitesurf!!!!", PubImage = "Assets/puremagic.png" });
            pubs.Add(new Models.Pub { PubId = 10, PubName = "Ted's", PubComment = "Central", PubImage = "Assets/teds.png" });
            pubs.Add(new Models.Pub { PubId = 11, PubName = "Valley House", PubComment = "Hello Squire!", PubImage = "Assets/vh.png" });

            return pubs;
        }
    }
}
