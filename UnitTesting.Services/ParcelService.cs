using UnitTesting.DataAccess;
using UnitTesting.Models;

namespace UnitTesting.Services
{
    public class ParcelService : IParcelService
    {
        private readonly IParcelDataAccess _parcelDA;

        public ParcelService(IParcelDataAccess parcelDA)
        {
            _parcelDA = parcelDA;
        }

        public Parcel GetParcel(int id)
        {

            return _parcelDA.GetParcel(id);
        }
    }
}
