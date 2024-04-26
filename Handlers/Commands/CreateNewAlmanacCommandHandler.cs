using System.Threading;
using System.Threading.Tasks;
using AdventurersAlmanac.Domain.Dtos;
// using MediatR;

namespace AdventurersAlmanac.Handlers.Commands
{
    public class CreateNewAlmanacCommandHandler //: IRequestHandler<CreateNewAlmanacCommand>
    {
        public async Task<string> Handle(CreateNewAlmanacCommand request, CancellationToken cancellationToken)
        {
            System.Console.WriteLine("Handling creaton of new almanac...");
            // TODO: Implement the logic to handle the CreateNewAlmanacCommand
            // You can access the properties of the command using request.PropertyName

            // Example:
            // var almanac = new Almanac(request.Title, request.Description);
            // _almanacRepository.Add(almanac);
            // await _almanacRepository.SaveChangesAsync();



            return "Almanac created successfully.";
        }
    }
}