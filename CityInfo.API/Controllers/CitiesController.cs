using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        // returns "200 OK" with "null" response - clearly not RESTful 
        // better alrternative is to return "IActionResult" and use OK()/NotFound() helper methods so correct status codes are returned
        // and also content negotiation sia automatically handled by MVC middleware
        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(city => city.Id == id));
        }
    }
}