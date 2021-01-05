﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IQueryable<Course> GetCourses()
        {
            return _context.Courses;
        }
        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
    }
}
