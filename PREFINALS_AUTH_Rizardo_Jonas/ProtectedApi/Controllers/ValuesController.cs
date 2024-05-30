using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        var userInfo = new
        {
            Name = "Jonas Rizardo",
            Section = "CS",
            Course = "Computer Science",
            FunFacts = new[]
            {
                "I love coding.",
                "I am a coffee enthusiast.",
                "I enjoy playing basketball.",
                "I have a dog named Spark.",
                "I am a movie buff.",
                "I love watching anime.",
                "I love one piece",
                "I enjoy playing computer games",
                "I love my girlfriend so much",
                "I enjoy traveling."
            }
        };

        return Ok(userInfo);
    }
}