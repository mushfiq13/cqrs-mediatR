using CqrsMediatR.Models;

namespace CqrsMediatR.Data
{
    public interface IAsyncDataAccess
    {
        Task<PersonModel> AddPerson(string firstName, string lastName);
        Task<List<PersonModel>> GetPeople();
    }
}