using CqrsMediatR.Data;
using CqrsMediatR.Models;
using CqrsMediatR.Services.Commands;
using MediatR;

namespace CqrsMediatR.Services.Handlers;

public class InsertPersonHandler
	: IRequestHandler<InsertPersonCommand, PersonModel>
{
	private readonly IAsyncDataAccess _data;

	public InsertPersonHandler(IAsyncDataAccess data)
	{
		_data = data;
	}

	public async Task<PersonModel> Handle(
		InsertPersonCommand request,
		CancellationToken cancellationToken)
	{
		return await _data.AddPerson(request.FirstName, request.LastName);
	}
}
