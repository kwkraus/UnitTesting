using UnitTesting.Models;

namespace UnitTesting.Services
{
    public interface IParcelService
    {
        Parcel GetParcel(int id);
    }
}