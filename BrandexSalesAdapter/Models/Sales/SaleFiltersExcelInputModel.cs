﻿namespace BrandexSalesAdapter.ExcelLogic.Models.Sales
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using BrandexSalesAdapter.ExcelLogic.Models.Enums;

    public class SaleFiltersExcelInputModel
    {
        public string Date { get; set; }

        public RegionInput Region { get; set; }

        public List<SelectListItem> Options { get; set; }

    }
}
