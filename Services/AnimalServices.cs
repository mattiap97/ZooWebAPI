using ZooWebAPI.Models;
using ZooWebAPI.Services.Interfaces;

namespace ZooWebAPI.Services
{
    public class AnimalServices : IAnimal
    {
        private static List<Animal> _animals = new List<Animal>()
        {
            new Animal()
            {
                Id = 1,
                Specie = "cane",
                Altezza = 20.4,
                Peso = 33.6
            }
        };

        public Animal AddNewAnimal(PostAnimal animal)
        {
            var animalToAdd = new Animal
            {
                Id = GetId(),
                Specie = animal.Specie,
                Altezza = animal.Altezza,
                Peso = animal.Peso,
            };

            _animals.Add(animalToAdd);
            return animalToAdd;
        }

        public List<Animal> GetAll() => _animals;


        public Animal GetById(int Id)
        {
            var AnimalId = _animals.FirstOrDefault(animals => animals.Id == Id);
            return AnimalId;
        }

        private int GetId()
        {
            if (_animals.Count == 0)
            {
                return 1;
            }

            return _animals.Max(animali => animali.Id) + 1;
        }

        public void DeleteAnimal(int id)
        {
            var animalDelete = _animals.Single(animale => animale.Id == id);
            _animals.Remove(animalDelete);
        }
    }
}
