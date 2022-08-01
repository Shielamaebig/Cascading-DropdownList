using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Cascading_DropdownList.Models;

namespace Cascading_DropdownList.Controllers
{
    public class DropdownController : Controller
    {
        private ApplicationDbContext _context;

        public DropdownController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Dropdown
        public ActionResult Index()
        {
            ViewBag.CountryList = new SelectList(GetCoutryList(), "CountryId", "CountryName" );
            return View();
        }
        public List<Country> GetCoutryList()
        {
            List<Country> countries = _context.Countries.ToList();

            return countries; 
        }
        public ActionResult GetStateList(int CountryId)
        {
            List<State> statesList = _context.States.Where(x => x.CountryId == CountryId).ToList();
            ViewBag.StateOptions = new SelectList(statesList, "StateId", "StateName");
            return PartialView("StateOptionPartial");
        }
    }
}