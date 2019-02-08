using UnitTesting.Models;

namespace UnitTesting.DataAccess
{
    public interface IParcelDataAccess
    {
        Parcel GetParcel(int id);
    }
}