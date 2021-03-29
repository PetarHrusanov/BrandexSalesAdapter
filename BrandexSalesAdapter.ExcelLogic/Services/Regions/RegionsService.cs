﻿namespace BrandexSalesAdapter.ExcelLogic.Services.Regions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using BrandexSalesAdapter.ExcelLogic.Data;
    using BrandexSalesAdapter.ExcelLogic.Data.Models;
    using BrandexSalesAdapter.ExcelLogic.Models.Regions;

    public class RegionsService :IRegionsService
    {
        SpravkiDbContext db;

        public RegionsService(SpravkiDbContext db)
        {
            this.db = db;
        }
        public async Task<bool> CheckRegionByName(string regionName)
        {
           return await this.db.Regions.Where(x => x.Name.ToLower().TrimEnd().Contains(regionName.ToLower().TrimEnd()))
                                    .Select(x => x.Id)
                                    .AnyAsync();
        }

        public async Task<int> IdByName(string regionName)
        {
            return await this.db.Regions.Where(x => x.Name.ToLower().TrimEnd().Contains(regionName.ToLower().TrimEnd()))
                                    .Select(x => x.Id)
                                    .FirstOrDefaultAsync();
        }

        public async Task<string> UploadRegion(string regionName)
        {
            if (regionName != null)
            {
                var regionDbModel = new Region
                {
                    Name = regionName
                };

                await this.db.Regions.AddAsync(regionDbModel);
                await this.db.SaveChangesAsync();
                return regionName;
            }
            else
            {
                return "";
            }
        }

        public async Task<List<SelectListItem>> RegionsForSelect()
        {
            return await this.db.Regions.Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Id.ToString(),
                                      Text = a.Name
                                  }).ToListAsync();
        }

        public async Task<RegionOutputModel[]> AllRegions()
        {
            var regionArray = await this.db.Regions.Select(a =>
                                  new RegionOutputModel
                                  {
                                      Id = a.Id,
                                      Name = a.Name
                                  }).ToArrayAsync();
            return regionArray;
        }
    }
}
