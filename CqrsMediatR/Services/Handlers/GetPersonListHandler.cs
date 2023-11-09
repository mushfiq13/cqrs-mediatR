using CqrsMediatR.Data;
using CqrsMediatR.Models;
using CqrsMediatR.Services.Queries;
using MediatR;

namespace CqrsMediatR.Services.Handlers;

public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
{
    private readonly IAsyncDataAccess _dataAccess;

    public GetPersonListHandler(IAsyncDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public async Task<List<PersonModel>> Handle(
        GetPersonListQuery request,
        CancellationToken cancellationToken)
    {
        return await _dataAccess.GetPeople();
    }
}
