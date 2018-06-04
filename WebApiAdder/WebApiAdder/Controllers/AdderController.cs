using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace WebApiAdder.Controllers
{
    public class AdderController : ApiController
    {
        //http://localhost:64390/api/adder?a=5&b=7
        public int Get(int a, int b)
        {
            return a + b;
        }

        /*
        //https://stackoverflow.com/questions/9981330/pass-an-array-of-integers-to-asp-net-web-api
        //http://localhost:64390/api/adder?a=5&b=7
        public int Get([FromUri] int[] nums)
        {
            int res = 0;
            foreach (int num in nums)
            {
                res += num;
            }
            return res;
        }
        */

        //https://stackoverflow.com/questions/9981330/pass-an-array-of-integers-to-asp-net-web-api
        //http://localhost:64390/api/adder?nums=1,7,11,33
        public int Get([FromUri] string nums)
        {
            var separated = nums.Split(new char[] { ',' });
            List<int> parsed = separated.Select(s => int.Parse(s)).ToList();

            int res = 0;
            foreach (int num in parsed)
            {
                res += num;
            }
            return res;
        }
    }
}
