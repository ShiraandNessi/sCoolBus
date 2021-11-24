﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IDriverDL
    {
        Task<List<Driver>> GetAllDrivers();
        public Task<Driver> GetDriverById(int id);
        public Task<int> AddNewDriver(Driver newDriver);
    }
}