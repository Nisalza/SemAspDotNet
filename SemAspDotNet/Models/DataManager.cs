using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemAspDotNet.Models
{
    public class DataManager
    {
        private Model1Container cont;
        public CourseWorkRepository CWR;
        public StudentRepository SR;
        public TeacherRepository TR;

        public DataManager()
        {
            cont = new Model1Container();
            CWR = new CourseWorkRepository(cont);
            SR = new StudentRepository(cont);
            TR = new TeacherRepository(cont);
        }
    }
}