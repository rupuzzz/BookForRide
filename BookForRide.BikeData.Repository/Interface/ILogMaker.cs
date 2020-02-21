using BookForRide.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.Repository.Interface
{
    public interface ILogMaker
    {
        void log(LogModel model);
    }
}
