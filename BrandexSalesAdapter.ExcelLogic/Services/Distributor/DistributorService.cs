﻿namespace BrandexSalesAdapter.ExcelLogic.Services.Distributor
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using BrandexSalesAdapter.ExcelLogic.Data;

    public class DistributorService :IDistributorService
    {
        SpravkiDbContext db;

        public DistributorService(SpravkiDbContext db)
        { 
            this.db = db;
        }

        public async Task<bool> CheckDistributor(string input)
        {
            return await this.db.Distributors.Where(d => d.Name == input).AnyAsync();
        }

        public async Task<int> IdByName(string input)
        {
            return await this.db.Distributors.Where(d => d.Name == input).Select(d => d.Id).FirstOrDefaultAsync();
        }
    }
}
