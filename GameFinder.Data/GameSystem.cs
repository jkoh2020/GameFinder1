using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Data
{
    public class GameSystem
    {
        [Key]
        public int Id { get; set; }
        public double Price { get; set; }
        public Guid OwnerId { get; set; }
        public string GameSystemTitle { get; set; }
        public string Description { get; set; }
        
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
        
    }
}
