using Microsoft.AspNetCore.Mvc;



public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }

    public IActionResult Claims()
    {
    return Ok("This is the Claims method of the CustomerCareController");
    }

        public IActionResult NewClaims()
        {
            return Ok("This is the New Claims method of the CustomerCareController");
        }
        public IActionResult ClaimsHistory()
        {
            return Ok("This is the Claims History method of the CustomerCareController");
        }

}