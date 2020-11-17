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
        public string GameTitle { get; set; }
        public string Description { get; set; }
        public Guid OwnerId { get; set; }

    }
}
