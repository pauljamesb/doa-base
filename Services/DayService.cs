using DOA.Data;
using DOA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOA.Services
{
    public class DayService : IDayService
    {

        private readonly ApplicationDbContext _db;
        public DayService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Day[]> GetIncompleteDaysAsync()
        {
            var myDays = await _db.AllDaysFromDb.ToArrayAsync();
            return myDays;
        }

    }
}
