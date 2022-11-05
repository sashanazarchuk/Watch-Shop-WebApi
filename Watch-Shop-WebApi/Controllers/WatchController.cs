using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Watch_Shop_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchController : ControllerBase
    {
        private readonly WatchShopDbContext context;
        private readonly IWatchServices watchService;

        public WatchController(WatchShopDbContext context, IWatchServices watchService)
        {
            this.context = context;
            this.watchService = watchService;
        }


        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(watchService.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var watch = watchService.GetById(id);

            if (watch == null) return NotFound();

            return Ok(watch);
        }

        [HttpPost]
        public IActionResult Create([FromBody] WatchDto watch)
        {
            watchService.Create(watch);

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] WatchDto watch)
        {
            watchService.Edit(watch);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            watchService.Delete(id);

            return Ok();
        }
    }
}