using ZooWebAPI.Models;

namespace ZooWebAPI.Services.Interfaces
{
    public interface IAnimal
    {
        public Animal AddNewAnimal(PostAnimal newAnimal);
        public List<Animal> GetAll();
        public Animal GetById(int Id);

        public void DeleteAnimal(int id);

    }
}
