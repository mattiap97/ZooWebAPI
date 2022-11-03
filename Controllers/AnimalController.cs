using Microsoft.AspNetCore.Mvc;
using ZooWebAPI.DAL.DataAccessService.Interfaces;
using ZooWebAPI.Models;
using ZooWebAPI.Models.Post;
using ZooWebAPI.Services.Interfaces;

namespace ZooWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IDataAccessService _dataAccessService;

        public AnimalController(IDataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;
        }

        [HttpPost()]
        public IActionResult CreateNewAnimal([FromBody] Animal animals)
        {
            var animaleAdded = _dataAccessService.AddAnimal(animals);

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
            return Ok(_dataAccessService.GetAnimals());
        }

        [HttpGet("{animalId}/animal")]
        public IActionResult GetAnimalById(int animalId)
        {
            var animal = _dataAccessService.GetAnimalById(animalId);
            if (animal == null)
                return NotFound();
            return Ok(animal);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            _dataAccessService.DeleteAnimal(id);

            return Ok(_dataAccessService.GetAnimals());
        }


        //[HttpPut()]
        //public IActionResult PutId( int id, [FromBody] PostAnimal animal)
        //{
        //    _animalService.Put(id, animal);
        //    return Ok();
        //}

        //[HttpGet("specie/{specie}")]
        //public IActionResult GetBySpecie(string specie)
        //{
        //    var animalBySpecie = _animalService.GetAnimalFromSpecie(specie);
        //    return Ok(animalBySpecie);
        //}

        //[HttpGet("peso")]
        //public IActionResult GetOrderPeso()
        //{
        //    var animalByPeso = _animalService.GetOrderByPeso();
        //    return Ok(animalByPeso);
        //}
    }
}
