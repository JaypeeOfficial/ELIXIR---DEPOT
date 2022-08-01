﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIXIR.DATA.DTOs.REPORT_DTOs
{
    public class QCReport
    {

        public int Id { get; set; }
        public string QcDate { get; set; }
        public int PONumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string Uom { get; set; }
        public string Category { get; set; }
        public decimal Quantity { get; set; }
        public string ManufacturingDate { get; set; }
        public string ExpirationDate { get; set; }
        public decimal TotalReject { get; set; }
        public string SupplierName { get; set; }
        public decimal Price { get; set; }
        public string QcBy { get; set; }


    }
}