using Microsoft.AspNetCore.Mvc;

public class AutoController : Controller
{
    public IActionReuslt Index()
    {
        return Ok("This is the index of the AutoController");
    }

    public IActionResulte Quote()
    {
        return Ok("This is the quote of the AutoController")
    }
}