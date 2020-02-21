using BookForRide.BikeData.Data;
using BookForRide.Repository.Interface;
using BookForRide.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.Repository.Concrete
{
    public class DataBaseContext : IDatabaseContext
    {
        private BookForRideEntities _Context;

        public DataBaseContext()
        {
            _Context = new BookForRideEntities();
        }
        public bool DeleteBikeDetailById(int id)
        {
            return _Context.DeleteBikeDetailById(id) ==0?false:true;
        }

        public IList<BikeData.Data.Bike> GetBikeDetail(int? id)
        {
            var resultlist = _Context.GetBikeDetail(id);
            var list = new List<BikeData.Data.Bike>();

            list = resultlist.Select(a => new BikeData.Data.Bike()
            {
               Color = a.Color,
               Id = a.Id,
               Mileage = a.Mileage,
               ModelNo = a.ModelNo,
               Name = a.Name,
               Photo = a.Photo,
               Speed = a.Speed
                
            }).ToList();
            return list;
        }

        public GetBikeDetail_Result GetBikeDetailById(int id)
        {
            var bike = _Context.GetBikeDetail(id);
            return bike.FirstOrDefault();
        }

        public void LogMaker(BookForRideLog model)
        {
            try
            {
                _Context.BookForRideLogs.Add(model);
                _Context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool PostBikeDetail(Entity.Bike bike)
        {
            return _Context.PostBikeDetail(bike.Name, bike.Color, bike.Speed, bike.ModelNo, bike.Mileage, bike.Photo) == 0 ? false : true;
        }

        public bool UpdateBikeDetail(Entity.Bike bike)
        {
            return _Context.PostBikeDetail(bike.Name, bike.Color, bike.Speed, bike.ModelNo, bike.Mileage, bike.Photo) == 0 ? false : true;

        }

        
    }
}
