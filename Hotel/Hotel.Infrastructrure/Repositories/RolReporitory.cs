



using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Context;

namespace Hotel.Infrastructrure.Repositories
{
    public class RolReporitory : IBaseRepository<RolReporitory>, IRolRepository
    {
        public RolReporitory(HotelContext hotelContext) { }
     
    }
}
