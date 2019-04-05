using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemAspDotNet.Models
{
    public class StudentRepository
    {
        private Model1Container cont;

        public StudentRepository(Model1Container _cont)
        {
            cont = _cont;
        }

        public IEnumerable<Student> Students()
        {
            return cont.StudentSet.OrderBy(cw => cw.Name);
        }
    }
}