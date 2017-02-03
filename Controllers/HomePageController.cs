using Microsoft.AspNetCore.Mvc;

public class HomePageController : Controller
{
    public IActionReuslt Index()
    {
        return Ok("This is the index of the HomePageController");
    }

    public IActionResulte Quote()
    {
        return Ok("This is the quote of the HomePageController")
    }
}