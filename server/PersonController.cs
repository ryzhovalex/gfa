using Microsoft.AspNetCore.Mvc;
namespace Gfa;

[ApiController]
[Route("rpc/person")]
public class PersonController : ControllerBase
{
    public struct GetArgs {
        public int Id {get; set;}
    }

    [HttpPost("get")]
    public Person Get(GetArgs args)
    {
        return new Person {Id = args.Id, Name = "Messi"};
    }
}
