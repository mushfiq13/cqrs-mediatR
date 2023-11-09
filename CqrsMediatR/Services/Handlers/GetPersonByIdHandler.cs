using CqrsMediatR.Models;
using CqrsMediatR.Services.Queries;
using MediatR;

namespace CqrsMediatR.Services.Handlers;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
{
	private readonly IMediator _mediator;

	public GetPersonByIdHandler(IMediator mediator)
	{
		_mediator = mediator;
	}

	public async Task<PersonModel> Handle(
		GetPersonByIdQuery request,
		CancellationToken cancellationToken)
	{
		var people = await _mediator.Send(new GetPersonListQuery());

		return people.FirstOrDefault(x => x.Id == request.Id)!;
	}
}
