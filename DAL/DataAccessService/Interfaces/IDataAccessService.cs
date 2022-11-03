using ZooWebAPI.Models;
using ZooWebAPI.Models.Post;

namespace ZooWebAPI.DAL.DataAccessService.Interfaces
{
    public interface IDataAccessService
    {
        public IEnumerable<Animal> GetAnimals();
        public Animal AddAnimal(PostAnimal Animal);
        public Animal GetAnimalById(int id);
        public void DeleteAnimal(int id);
        public Animal UpdateAnimal(Animal animal);
    }
}