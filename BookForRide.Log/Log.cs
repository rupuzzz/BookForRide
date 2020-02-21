using BookForRide.Repository.Interface;
using BookForRide.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.Log
{
    public  class Log 
    {
        private  readonly ILogMaker _logMaker;

        public Log(ILogMaker logMaker)
        {
            _logMaker = logMaker;
        }

        public void WriteLog(LogModel model)
        {
            try
            {
                _logMaker.log(model);
            }
            catch
            {
                throw; ;
            }
        }
    }
}
