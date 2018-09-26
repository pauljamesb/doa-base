using DOA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOA.Services
{
    public interface IDayService
    {
        Task<Day[]> GetIncompleteDaysAsync();
    }
}
