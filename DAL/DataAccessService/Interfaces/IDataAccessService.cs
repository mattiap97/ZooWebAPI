using ZooWebAPI.Models;
using ZooWebAPI.Models.Post;

namespace ZooWebAPI.DAL.DataAccessService.Interfaces
{
    public interface IDataAccessService
    {
        public Animal GetAllAnimal(PostAnimal pAnimal);
        public Animal AddAnimal(Animal Animal);
        public Animal GetAnimalById(int id);
        public void DeleteAnimal(int id);
        public Animal UpdateAnimal(Animal animal);
    }
}