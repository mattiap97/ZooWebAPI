using Microsoft.EntityFrameworkCore;
using ZooWebAPI.DAL.DataAccessService.Interfaces;
using ZooWebAPI.Models;
using ZooWebAPI.Models.Post;

namespace ZooWebAPI.DAL.DataAccessService
{
    public class DbDataAccessService : IDataAccessService
    {
        private readonly ZooDbContext _ctx;

        public DbDataAccessService(ZooDbContext ctx)
        {
            _ctx = ctx;
        }

        public Animal AddAnimal(PostAnimal animal)
        {
            //var animalToAdd = new Animal
            //{
            //    Id = GetId(),
            //    Specie = animal.Specie,
            //    Altezza = animal.Altezza,
            //    Peso = animal.Peso,
            //};
            var animalAdded = _ctx.Animals.Add(animal);
            _ctx.SaveChanges();
            return animal;
        }

        public void DeleteAnimal(int id)
        {
            var animalDeleted = _ctx.Animals.Single(animal => animal.Id == id);
            _ctx.Animals.Remove(animalDeleted);
            _ctx.SaveChanges();
        }

        //public Animal GetAllAnimal()
        public IEnumerable<Animal> GetAnimals()

        {
            var animal = _ctx.Animals;
            return animal;
        }

        public Animal GetAnimalById(int id)
        {
            var animal = _ctx.Animals.SingleOrDefault(animal => animal.Id == id);
            return animal;
        }

        public Animal UpdateAnimal(Animal animal)
        {

        }
    }
}
