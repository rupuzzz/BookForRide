using Ninject;

namespace BookForRide.BikeData.API.App_Start
{
    internal class NinjectWebApiFilterProvider
    {
        private StandardKernel kernel;

        public NinjectWebApiFilterProvider(StandardKernel kernel)
        {
            this.kernel = kernel;
        }
    }
}