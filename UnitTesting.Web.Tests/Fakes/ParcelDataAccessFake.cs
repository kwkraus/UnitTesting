using UnitTesting.DataAccess;
using UnitTesting.Models;

namespace UnitTesting.Web.Tests.Fakes
{
    public class ParcelDataAccessFake : IParcelDataAccess
    {
        public Parcel GetParcel(int id)
        {
            return new Parcel
            {
                Id = 2,
                Name = "Mike's House",
                Township = "Las Vegas",
                Owner = "Clark County"
            };
        }
    }
}
