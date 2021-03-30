using Assignment10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Components
{
    public class TeamViewComponent: ViewComponent
    {
        //create context variable
        private BowlingLeagueContext context;
        //Build the constructor
        public TeamViewComponent(BowlingLeagueContext con)
        {
            context = con;
        }
        //What do you want me to do when this is called
        public IViewComponentResult Invoke()
        {
            //get the team data in this invoke for the view component so we can display this
            return View(context.Teams.Distinct().OrderBy(x=>x));
        }

    }
}
