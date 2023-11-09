using CqrsMediatR.Models;
using MediatR;

namespace CqrsMediatR.Services.Queries;

public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
