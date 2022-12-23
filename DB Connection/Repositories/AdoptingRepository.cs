﻿using AnimalAdoption.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.DB_Connection.Repositories
{
    public class AdoptingRepository:Repository<Adoption>
    {
        private readonly DataBaseContext _dataBaseContext;
        public AdoptingRepository(DataBaseContext dataBaseContext) : base(dataBaseContext)
        {
            this._dataBaseContext = dataBaseContext;
        }


     
    }
}
