using GameFinder.Data;
using GameFinder.Models;
using GameFinder.Services;
using GameFinder.WebAPI.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GameFinder.WebAPI.Controllers
{
    public class GameSystemController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private GameSystemService CreateService()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var gameSystemService = new GameSystemService(userid);
            return gameSystemService;
        }

        // Post game system
        public IHttpActionResult Create(PostSystem gameSystem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateService();
            if (!service.CreateSystem(gameSystem))
                return InternalServerError();

            return Ok();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<GameSystem> gameSystems = await _context.GameSystems.ToListAsync();
            return Ok(gameSystems);
        }
    }
}
