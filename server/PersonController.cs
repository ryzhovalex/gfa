using Microsoft.AspNetCore.Mvc;
namespace Gfa;

[ApiController]
[Route("rpc/person")]
public class PersonController : ControllerBase
{
    public struct GetArgs {
        public int Id {get; set;}
    }
    public struct CreateArgs {
        public string Firstname {get; set;}
    }

    private readonly Database db;
    public PersonController(Database db) {
        this.db = db;
    }

    [HttpPost("get")]
    public Person Get(GetArgs args) {
        return db.Person.First();
    }

    [HttpPost("create")]
    public Person Create(CreateArgs args) {
        var person = new Person {Firstname = args.Firstname};
        db.Add(person);
        db.SaveChanges();
        return person;
    }
}
