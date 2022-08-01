using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cascading_DropdownList.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}