using CqrsMediatR.Models;

namespace CqrsMediatR.Data;

public class DemoDataAccess : IAsyncDataAccess
{
    private List<PersonModel> _people = new();

    public DemoDataAccess()
    {
        _people.Add(new PersonModel { Id = 1, FirstName = "Sue", LastName = "Smith" });
        _people.Add(new PersonModel { Id = 2, FirstName = "John", LastName = "Doe" });
    }

    public async Task<List<PersonModel>> GetPeople()
    {
        return await Task.FromResult(_people);
    }

    public async Task<PersonModel> AddPerson(
        string firstName,
        string lastName)
    {
        var maxId = _people.Max(x => x.Id);
        var newPerson = new PersonModel { Id = maxId + 1, FirstName = firstName, LastName = lastName };

        _people.Add(newPerson);

        return await Task.FromResult(newPerson);
    }
}
