using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemAspDotNet.Models
{
    public class CourseWorkRepository
    {
        private Model1Container cont;

        public CourseWorkRepository(Model1Container _cont)
        {
            cont = _cont;
        }

        public IEnumerable<CourseWork> CourseWorks()
        {
            return cont.CourseWorkSet.OrderBy(cw => cw.Title);
        }

        public CourseWork GetCourseWork(int _id)
        {
            return cont.CourseWorkSet.Find(_id);
        }

        public void Add(string title, byte mark, byte course, int student, int teacher)
        {
            CourseWork cw = new CourseWork();
            cw.Title = title;
            cw.Mark = mark;
            cw.Course = course;
            cw.Student = cont.StudentSet.Find(student);
            cw.Teacher = cont.TeacherSet.Find(teacher);

            cont.CourseWorkSet.Add(cw);
            cont.SaveChanges();
        }

        public void Delete(int id)
        {
            cont.CourseWorkSet.Remove(GetCourseWork(id));
            cont.SaveChanges();
        }

        public void Edit(int id, string title, byte mark, byte course, int student, int teacher)
        {
            CourseWork cw = GetCourseWork(id);
            cw.Title = title;
            cw.Mark = mark;
            cw.Course = course;
            cw.Student = cont.StudentSet.Find(student);
            cw.Teacher = cont.TeacherSet.Find(teacher);

            cont.SaveChanges();
        }
    }
}