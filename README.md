# Cqrs And MediatR

Install package: MediatR 

Register all assemblies:
```cs
builder.Services.AddMediatR( 
  cfg =>  cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));
```
 
Example of Query and related handler:

```json
// this is the query, it requests a list of person model 
public record GetPersonListQuery() : IRequest<List<PersonModel>>; 

// first type of IRequestHandler must be a query or command 
public class GetPersonListHandler
  : IRequestHandler<GetPersonListQuery, List<PersonModel>> {
  /* Handle all the things... */
} 
```

For example, our Api needs to a list of people. API asks mediator for data, sends which query needs to get executed which is, for example, `GetPersonListQuery`. Mediator will use the `GetPersonListHandler` that handles `GetPersonListQuery` and returns a list of `PersonModel`.

Usage:

```cs
// inject: IMediator mediator 
List<PersonModel> people = await mediator.Send(new GetPersonListQuery());
```
