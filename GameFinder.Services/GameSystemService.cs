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
    public class GameSystemService
    {
        private readonly Guid _userId;
        public GameSystemService(Guid userId)
        {
            _userId = userId;
        }

        // Posting a gamesystem
        public bool CreateSystem(PostSystem model)
        {
            var entity = new GameSystem()
            {
                OwnerId = _userId,
                // data             model
                Price = model.Price,
                GameSystemTitle = model.Title,
                Description = model.SDescription,
                GameId = model.GameId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.GameSystems.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // Get gamessystem

        public IEnumerable<GetGameSystem> GetSystem()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                            .GameSystems
                            .Where(e => e.OwnerId == _userId)
                            .Select(e => new GetGameSystem
                            {
                            // model    data
                                Id = e.Id,
                                Title = e.GameSystemTitle,
                                GSDescription = e.Description,
                                Price = e.Price
                            });
                return query.ToArray();
                            
            }
        }
    }
}
