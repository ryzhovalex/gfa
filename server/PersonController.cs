using Microsoft.AspNetCore.Mvc;
namespace Gfa;

[ApiController]
[Route("rpc/person")]
public class PersonController : ControllerBase
{
    [HttpPost("get")]
    public Person Get(Person person)
    {
        return person;
        return new Person {Name = "Messi"};
    }
}
