using MyCVSite.Interfaces;
using MyCVSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVSite.Mocks
{
    public class MockCourse : IAllCourse
    {
        //Was for testing (not recommended)
        //Now everything is stored in the database
        public IEnumerable<Сourse> Courses {
            get
            {
                return new List<Сourse>
                {
                    new Сourse { dateTime = new DateTime(2016, 3, 21), desc = "Cisco Networking Academy", img="/img/Cisco.jpg"},
                    new Сourse { dateTime = new DateTime(2018, 4, 20), desc = "Diploma of graduation from STEP Computer Academy", img="/img/Step.jpg"},
                    new Сourse { dateTime = new DateTime(2020, 6, 15), desc = "Bachelor's diploma", img="/img/Diploma.jpg"},
                    new Сourse { dateTime = new DateTime(2021, 6, 14), desc = "Certificate of completion SMART ACADEMY", img="/img/Smart.jpg"}
                };
            }
        }

        public Сourse getCourse(int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
