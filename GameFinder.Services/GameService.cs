using GameFinder.Data;
using GameFinder.Models;
using GameFinder.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Services
{
    public class GameService
    {
        private readonly Guid _userId;
        public GameService(Guid userId) // Creater a constructor
        {
            _userId = userId;
        }

        // Posting a game

        public bool CreatePost(PostAGame model)
        {
            var entity = new Game()
            {
                       
                OwnerId = _userId,
                // data         model
                GameTitle = model.Title,
                Description = model.GDescription,
                Genre = model.Genre
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // Get games

        public IEnumerable<GetGames> GetGame()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Games // it comes from DbSet
                        .Where(e => e.OwnerId == _userId)
                        .Select(e => new GetGames
                        {
                       // model      data
                            Id = e.GameId,
                            Title = e.GameTitle,
                            GDescription = e.Description,
                            Genre = e.Genre
                        });
                return query.ToArray();
            }
        }
    }
}
