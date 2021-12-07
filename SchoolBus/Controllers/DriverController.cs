﻿using BL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolBus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        IDriverBL IDriverBL;
        public DriverController(IDriverBL IDriverBL)
        {
            this.IDriverBL = IDriverBL;
        }
        // GET: api/<DriverController>
        [HttpGet]
        public async Task<List<Driver>> Get()
        {
            return await IDriverBL.GatAllDrivers();
        }

        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public async Task<Driver> Get(int id)
        {
            return await IDriverBL.GatDriverById(id);
        }

        // POST api/<DriverController>
        [HttpPost]
        public async Task<Driver> Post(string passsword,[FromBody] Driver newDriver)
        {
           return await IDriverBL.AddNewDriver(newDriver, passsword);
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Driver driverToUpdate,string password,  string newPassword)
        {
            await IDriverBL.changeDriverdetails(id, driverToUpdate, password, newPassword);
        }
        

        

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await IDriverBL.removeDriver(id);
        }
    }
}
