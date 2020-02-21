using data = BookForRide.BikeData.Data;
using BookForRide.Repository.Interface;
using BookForRide.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.Repository.Concrete
{
    public class BikeOperation : IBikeOperation
    {
        private IDatabaseContext _Context;

        public BikeOperation(IDatabaseContext bookForRideEntities)
        {
            _Context = bookForRideEntities;
        }
        public bool DeleteBikeDetailById(int id)
        {
            try
            {
                return _Context.DeleteBikeDetailById(id);
            }
            catch
            {
                throw;
            }
        }

        public  IList<Bike> GetBikeDetail(int? id)
        {
            try
            {
                return _Context.GetBikeDetail(id).Select(a => new Bike()
                {
                    Color = a.Color,
                    Id = a.Id,
                    Mileage = a.Mileage,
                    ModelNo = a.ModelNo,
                    Name = a.Name,
                    Photo = a.Photo,
                    Speed = a.Speed
                }).ToList();
            }
            catch
            {
                throw;
            }
        }

        public Bike GetBikeDetailById(int id)
        {
            try
            {
                var bike  = _Context.GetBikeDetailById(id);

                //return new Bike()
                //{
                //    Id = bike.Id,
                //    Color = bike.Color,
                //    Mileage = bike.Mileage,
                //    ModelNo = bike.ModelNo,
                //    Name = bike.Name,
                //    Photo = bike.Photo,
                //    Speed = bike.Speed
                //};

                return Utility.Utility.Cast<Bike>(bike);
                    
            }
            catch
            {
                throw;
            }
        }

        public bool PostBikeDetail(Bike bike)
        {
            try
            {
               
                return _Context.PostBikeDetail(bike);
            }
            catch
            {
                throw;
            }
        }

        public bool UpdateBikeDetail(Bike bike)
        {
            try
            {
               
                return _Context.UpdateBikeDetail(bike);
            }
            catch
            {
                throw;
            }
        }
    }
}
