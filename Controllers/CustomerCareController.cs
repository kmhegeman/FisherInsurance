using Microsoft.AspNetCore.Mvc;



public class CustomerCareController : Controller
{
    [Route("customer")]
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }

    public IActionResult Claims()
    {
    return Ok("This is the Claims method of the CustomerCareController");
    }
    [Route("customer/fileclaim")] [Route("customer/claim/fileclaim")]
        public IActionResult NewClaims()
        {
            return Ok("This is the New Claims method of the CustomerCareController");
        }
        [Route("customer/claimstatus")] [Route("customer/claim/myclaims")]
        public IActionResult ClaimsHistory()
        {
            return Ok("This is the Claims History method of the CustomerCareController");
        }

}