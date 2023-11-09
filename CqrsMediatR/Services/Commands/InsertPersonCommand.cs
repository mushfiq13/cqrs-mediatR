using CqrsMediatR.Models;
using MediatR;

namespace CqrsMediatR.Services.Commands;

public record InsertPersonCommand(string FirstName, string LastName)
	: IRequest<PersonModel>;
