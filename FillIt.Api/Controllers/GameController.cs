using Microsoft.AspNetCore.Mvc;

namespace fill_it.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController(ILogger<GameController> logger) : ControllerBase
{
    private readonly ILogger<GameController> _logger = logger;

    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok("GameController");
    }
    
    [HttpGet("question")]
    public ActionResult<string> GetQuestion()
    {
        var question = "Mixing {0} and {1} make grand-pa explode!";
        
        return Ok(question);
    }

    [HttpGet("answers")]
    public ActionResult<string[]> GetAnswers()
    {
        var answers = new string[]
        {
            "Pizza",
            "Phone",
            "Coco the Bird",
            "Mentos",
            "Car",
            "Broom",
            "Left",
            "Head"
        };
        
        return Ok(answers);
    }
}
