using BookForRide.BikeData.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.Repository.Interface
{
   public interface IDatabaseContext 
    {

        IList<Bike> GetBikeDetail(int? id);
        GetBikeDetail_Result GetBikeDetailById(int id);
        bool UpdateBikeDetail(Entity.Bike bike);
        bool DeleteBikeDetailById(int id);

        bool PostBikeDetail(Entity.Bike bike);

        void LogMaker(BookForRideLog model);
    }
}
