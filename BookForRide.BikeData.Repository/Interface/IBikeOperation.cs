using BookForRide.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.Repository.Interface
{
    public interface IBikeOperation
    {
       IList<Bike> GetBikeDetail(int? id);
        Bike GetBikeDetailById( int id);
        bool UpdateBikeDetail(Bike bike);
        bool DeleteBikeDetailById(int id);

        bool PostBikeDetail(Bike bike);

    }
}
