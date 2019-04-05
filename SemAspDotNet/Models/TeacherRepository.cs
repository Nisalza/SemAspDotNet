using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemAspDotNet.Models
{
    public class TeacherRepository
    {
        private Model1Container cont;

        public TeacherRepository(Model1Container _cont)
        {
            cont = _cont;
        }

        public IEnumerable<Teacher> Teachers()
        {
            return cont.TeacherSet.OrderBy(cw => cw.Name);
        }
    }
}