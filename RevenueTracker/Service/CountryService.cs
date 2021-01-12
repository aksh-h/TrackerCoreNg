using Microsoft.EntityFrameworkCore;
using RevenueTracker.Data;
using RevenueTracker.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevenueTracker.Service
{
    public class CountryService : ICountry
    {
        private RevenueTrackerContext _context;

        public CountryService(RevenueTrackerContext context)
        {
            _context = context;
        }
        public async Task<List<TblCountryMaster>> GetAllCountry()
        {
            return await _context.TblCountryMasters.AsNoTracking().ToListAsync();
        }
    }
}
