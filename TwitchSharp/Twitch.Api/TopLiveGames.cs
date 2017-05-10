using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Api.TopGames
{

    public class Box
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string small { get; set; }
        public string template { get; set; }
    }

    public class Logo
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string small { get; set; }
        public string template { get; set; }
    }

    public class Game
    {
        public int _id { get; set; }
        public Box box { get; set; }
        public int giantbomb_id { get; set; }
        public Logo logo { get; set; }
        public string name { get; set; }
        private string _name { get; set; }
        public int popularity { get; set; }
    }

    public class Top
    {
        public int channels { get; set; }
        public int viewers { get; set; }
        public Game game { get; set; }
    }

    public class TopGames
    {
        public int _total { get; set; }
        public List<Top> top { get; set; }
    }

}
