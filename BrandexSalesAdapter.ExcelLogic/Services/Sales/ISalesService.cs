﻿namespace BrandexSalesAdapter.ExcelLogic.Services.Sales
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BrandexSalesAdapter.ExcelLogic.Models.Sales;

    public interface ISalesService
    {
        Task CreateSale(SaleInputModel sale, string distributor);

        Task<bool> UploadIndividualSale(string pharmacyId, string productId, string date, int count, string distributor);

        Task<int> ProductCountSumById(int productId, int? regionId);

        Task<int> ProductCountSumByIdDate(int productId, DateTime dateTime, int? regionId);

        Task<List<DateTime>> GetDistinctDatesByMonths();

    }
}
