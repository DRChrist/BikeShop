using System;
using System.Collections.Generic;
using BikeShop.Data;
using BikeShop.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BikeShop.Models.Repositories
{
    public class BikeRepository : IBikeRepository
    {
        private ApplicationDbContext _db;

        private DbSet<Bike> _bikes;

        public BikeRepository(ApplicationDbContext db)
        {
            _db = db;
            _bikes = db.Bikes;
        }

        public void Delete(Bike bike)
        {
            _db.Bikes.Remove(bike);
            _db.SaveChanges();
        }

        public Bike Get(int id)
        {
            Bike b = _db.Bikes.Find(id);
            return b;
        }

        public IEnumerable<Bike> GetAll()
        {
            return _bikes;
        }

        public void Save(Bike bike)
        {
            _db.Add(bike);
            _db.SaveChanges();
        }

        public void Update(Bike bike)
        {
            _db.Update(bike);
            _db.SaveChanges();
        }
    }
}