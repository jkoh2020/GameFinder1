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
    [Authorize]
    public class GameController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private GameService CreateService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var gameService = new GameService(userId);
            return gameService;
        }

        public IHttpActionResult Create(PostAGame post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateService();
            if (!service.CreatePost(post))
                return InternalServerError();
            return Ok(); // 200

        }

        // Read
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Game> posts = await _context.Games.ToListAsync();
            return Ok(posts);
        }
    }
}
