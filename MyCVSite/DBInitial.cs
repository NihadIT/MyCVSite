using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyCVSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVSite
{
    public class DBInitial
    {
        public static void Initial(Context dbContext)
        {
         
            if (!dbContext.Courses.Any())
            {
                dbContext.AddRange(
                    new Сourse { dateTime = new DateTime(2016, 3, 21), desc = "Cisco Networking Academy", img = "/img/Cisco.jpg" },
                    new Сourse { dateTime = new DateTime(2018, 4, 20), desc = "Diploma of graduation from STEP Computer Academy", img = "/img/Step.jpg" },
                    new Сourse { dateTime = new DateTime(2020, 6, 15), desc = "Bachelor's diploma", img = "/img/Diploma.jpg" },
                    new Сourse { dateTime = new DateTime(2021, 6, 14), desc = "Certificate of completion SMART ACADEMY", img = "/img/Smart.jpg" }
                    );
            }
            dbContext.SaveChanges();
        }
    }
}
