using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _context;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _context = universityDBContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
