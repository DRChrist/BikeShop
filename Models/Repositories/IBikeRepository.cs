using System.Collections.Generic;
using BikeShop.Models.Entities;

namespace BikeShop.Models.Repositories
{
    public interface IBikeRepository
    {
        IEnumerable<Bike> GetAll();

        Bike Get(int id);

        void Delete(Bike bike);

        void Update(Bike bike);

        void Save(Bike bike);
    }
}