using GameFinder.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Models
{
    public class GetGames
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string GDescription { get; set; }
        public Guid OwnerId { get; set; }
        public Genre Genre { get; set; }

    }
}
