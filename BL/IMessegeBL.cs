﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IMessegeBL
    {
        Task<List<Messege>> GetAllMesseges();
        Task<int> AddNewMessege(Messege newMessege);
    }
}