using BookForRide.Repository.Concrete.Utility;
using BookForRide.Repository.Interface;
using BookForRide.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookForRide.BikeData.API.Controllers
{
    public class BikeController : ApiController
    {
        private readonly IBikeOperation _bikeoperation;

        
        public BikeController(IBikeOperation bikeoperation)
        {
            _bikeoperation = bikeoperation;
        }
        public IList<Entity.Bike> GetBikeDetail()
        {
            return _bikeoperation.GetBikeDetail(0);
        }

        public Entity.Bike GetBikeDetailById(int id)
        {
            var bike = _bikeoperation.GetBikeDetailById(id);
            return Utility.Cast<Bike>(bike);
        }

        public bool UpdateUpdateBikeDetail(Bike bike)
        {
            var checkUpdate = _bikeoperation.UpdateBikeDetail(bike);
            return checkUpdate;
        }

        public bool DeleteBikeDetailById(int id)
        {
            var checkdelete = _bikeoperation.DeleteBikeDetailById(id);
            return checkdelete;
        }

        public bool PostBikeDetail(Bike bike)
        {
            var checkpost = _bikeoperation.PostBikeDetail(bike);
            return checkpost;
        }
    }
}
