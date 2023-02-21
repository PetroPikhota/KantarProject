using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace KantarProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string SortData, bool IsReverse)
        {
            try
            {
                if (!string.IsNullOrEmpty(SortData))
                {

                    string[] str = SortData.Split();
                    int[] tab = SortData.Split().Where(x=> !string.IsNullOrWhiteSpace(x)). Select(x => int.Parse(x.Trim())).ToArray();
                    Array.Sort(tab);
                    if (IsReverse) Array.Reverse(tab);
                    ViewData["SortedData"] = string.Join(" ", tab);
                }
                return View();
            }catch(Exception ex)
            {
                ViewData["ErrorData"] = ex.Message;
                return View("Error");
            }
        }

    }
}
