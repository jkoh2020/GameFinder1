using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Data
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string GameTitle { get; set; }

        [Required]
        public string Description { get; set; }

    }
    public enum Genre
    {
        Platform,
        FPS,
        Survival,
        Rhythm,
        RTS,
        MMORPG,
        Roguelikes,
        Simulation,
        Crafting,
        Sports,
        Strategy
    }
}
