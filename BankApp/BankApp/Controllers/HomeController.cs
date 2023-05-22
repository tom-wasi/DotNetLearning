using Microsoft.AspNetCore.Mvc;

namespace BankApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("account-details")]
        public IActionResult Index()
        {
            return Json("/account.json", "text/json");
        }

        [Route("account-statement")]
        public IActionResult Bank()
        {
            return File("/sample.pdf", "application/pdf");
        }

        [Route("get-current-balance/{accountNumber:int}")]
        public IActionResult Balance(int accountNumber)
        {
            // if (string.IsNullOrEmpty(Convert.ToString(Request.Query["accountNumber"])))
            //  {
            //      return BadRequest("Must provide the account number");
            //
            //   }
            if (accountNumber <= 0)
            {
                return BadRequest("account number cannot be less or equal to zero");
            }

            int id = Convert.ToInt32(Request.RouteValues["accountNumber"]);

            if (id != 1001)
            {
                return StatusCode(400);
            }

            return Content("5000", "text/application");

        }
    }
}
