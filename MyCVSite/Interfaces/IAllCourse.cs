using MyCVSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVSite.Interfaces
{
   public interface IAllCourse
    {
        IEnumerable<Сourse> Courses { get; }
        Сourse getCourse(int courseId);
    }
}
