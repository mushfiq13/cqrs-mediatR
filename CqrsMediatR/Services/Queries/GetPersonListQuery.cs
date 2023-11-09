using CqrsMediatR.Models;
using MediatR;

namespace CqrsMediatR.Services.Queries;

public record GetPersonListQuery() : IRequest<List<PersonModel>>;
