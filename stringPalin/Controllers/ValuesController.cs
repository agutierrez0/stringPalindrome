using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace stringPalin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // Declaration of string array
        public static string[] arr1 = new string[1];

        // Method to determine if array is a palindrome.
        public static bool getStatus(string myString)
        {
            // essentially splitting the array into two and comparing the two.
            string firstHalf = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string secondHalf = temp.Substring(0, temp.Length / 2);
            // if the two are equal, it is a palindrome.
            return firstHalf.Equals(secondHalf);
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // output
            if (getStatus(arr1[0]) == true)
                return Ok(arr1[0] + " is a palindrome.");
            else
                return Ok(arr1[0] + " is not a palindrome.");
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // input
            arr1[0] = value;
        }
    }
}