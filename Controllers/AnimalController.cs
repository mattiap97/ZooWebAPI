using Microsoft.AspNetCore.Mvc;
using ZooWebAPI.Models;
using ZooWebAPI.Services.Interfaces;

namespace ZooWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimal _animalService;

        public AnimalController(IAnimal animalService)
        {
            _animalService = animalService;
        }

        [HttpPost()]
        public IActionResult CreateNewAnimal([FromBody] PostAnimal animals)
        {
            var animaleAdded = _animalService.AddNewAnimal(animals);

            return Ok();
        }

        //[HttpPost]
        //public IActionResult AddAnimale([FromBody] PostAnimale animale)
        //{
        //    var animaleAdd = _service.AddAnimale(animale);
        //    return Ok();
        //}

        [HttpGet()]
        public IActionResult GetAll()
        {
            //var animals = _animalService.GetAll();
            return Ok(_animalService.GetAll());
            //return Ok(_service.GetAll());
        }

        [HttpGet("{animalId}/animal")]
        public IActionResult GetAnimalById(int animalId)
        {
            var animal = _animalService.GetById(animalId);
            if (animal == null)
                return NotFound();
            return Ok(animal);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            _animalService.DeleteAnimal(id);

            return Ok(_animalService.GetAll());
        }
    }
}
