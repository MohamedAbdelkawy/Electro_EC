﻿using DepiEC.DataAccess.Data;
using DepiEC.DataAccess.Repository.IRepository;
using DepiEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepiEC.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
