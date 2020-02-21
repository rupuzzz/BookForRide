using BookForRide.Repository.Interface;
using BookForRide.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.Repository.Concrete
{
    public class LogMaker : ILogMaker
    {
        private readonly IDatabaseContext _dbContext;

        public LogMaker(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void log(LogModel model)
        {
            try
            {
                
            }
            catch
            {
                throw;
            }
        }
    }
}
