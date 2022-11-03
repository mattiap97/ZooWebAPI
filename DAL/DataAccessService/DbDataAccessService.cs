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

        public Animal AddAnimal(Animal animal)
        {
            var animalAdded = _ctx.Animals.Add(animal);
            _ctx.SaveChanges();
            return animal;
        }

        public void DeleteAnimal(int id)
        {
            throw new NotImplementedException();
        }

        public Animal GetAllAnimal(PostAnimal pAnimal)
        {
            throw new NotImplementedException();
        }

        public Animal GetAnimalById(int id)
        {
            var animal = _ctx.Animals.SingleOrDefault(animal => animal.Id == id);
            return animal;
        }

        public Animal UpdateAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
