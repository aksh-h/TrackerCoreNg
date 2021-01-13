using RevenueTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevenueTracker.IRepository
{
    public interface IMaster
    {
        Task<List<TblCountryMaster>> GetAllCountry();

        Task<List<TblStateMaster>> GetAllStates();
    }
}
