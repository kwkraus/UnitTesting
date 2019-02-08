using UnitTesting.Models;

namespace UnitTesting.DataAccess
{
    public class ParcelDataAccess : IParcelDataAccess
    {
        public Parcel GetParcel(int id)
        {
            return new Parcel
            {
                Id = 1,
                Name = "Govt Center",
                Township = "Las Vegas",
                Owner = "Clark County"
            };
        }

        //public void ProcessParcel
    }
}
