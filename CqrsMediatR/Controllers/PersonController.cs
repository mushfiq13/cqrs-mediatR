using CqrsMediatR.Models;
using CqrsMediatR.Services.Commands;
using CqrsMediatR.Services.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatR.Controllers;

[ApiController]
[Route("person")]
public class PersonController : ControllerBase
{
	private readonly IMediator _mediator;

	public PersonController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet("get")]
	public async Task<ActionResult<List<PersonModel>>> Get()
	{
		return await _mediator.Send(new GetPersonListQuery());
	}

	[HttpGet("get/{id:int}")]
	public async Task<ActionResult<PersonModel>> Get(int id)
	{
		return await _mediator.Send(new GetPersonByIdQuery(id));
	}

	[HttpPost("create")]
	public async Task<ActionResult<PersonModel>> Create(PersonModel model)
	{
		return await _mediator.Send(new InsertPersonCommand(
			model.FirstName,
			model.LastName));
	}
}
