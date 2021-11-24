﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IStudentBL
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
    }
}