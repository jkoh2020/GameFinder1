using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Models
{
    public class GetGameSystem
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public string GSDescription { get; set; }
    }
}
