using Microsoft.AspNetCore.Mvc;
namespace ControllerExample.Controllers;
using ControllerExample.Models;
public class CountriesController : Controller
{
    [Route("/countries")]
    public ContentResult Index()
    {
        return Content("<h1>Countries:</h2>", "text/html");
        return Content("<h2>Countries:</h2>", "text/html");
        return Content("<h2>Countries:</h2>", "text/html");
        return Content("<h2>Countries:</h2>", "text/html");
        return Content("<h2>Countries:</h2>", "text/html");
        return Content("<h2>Countries:</h2>", "text/html");
    }


    [Route("/countries/united-states")]
    public JsonResult USShow()
    {
        Country country = new Country()
        {
            Id = 1,
            countryName = ",United States"
        };
        JsonResult tmpJson = new JsonResult(country);
        return Json(tmpJson);
            
    }

    [Route("/countries/canada")]

    public JsonResult CanadaShow()
    {
        Country country = new Country()
        {
            Id = 2,
            countryName = "Canada"
        };
        return new JsonResult(country);
    }

    [Route("/countries/united-kingdom")]

    public JsonResult UKShow()
    {
        Country country = new Country()
        {
            Id = 3,
            countryName = "United Kingdom"
        };
        return new JsonResult(country);
    }
    [Route("/countries/india")]

    public JsonResult IndiaShow()
    {
        Country country = new Country()
        {
            Id = 4,
            countryName = "India"
        };
        return new JsonResult(country);
    }

    [Route("/countries/japan")]

    public JsonResult CountryShow()
    {
        Country country = new Country()
        {
            Id = 5,
            countryName = "Japan"
        };
        return new JsonResult(country);
    }
}

