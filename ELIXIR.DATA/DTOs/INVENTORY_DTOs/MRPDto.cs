﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIXIR.DATA.DTOs.INVENTORY_DTOs
{
    public class MRPDto
    {

        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCategory { get; set; }
        public string Uom { get; set; }
        public decimal Price { get; set; }
        public decimal SOH { get; set; }
        public decimal Reserve { get; set; }
        public decimal BufferLevel { get; set; }
        public decimal ReceiveIn { get; set; }
        public decimal ReceiptIn { get; set; }
        public decimal MoveOrderOut { get; set; }
        public decimal IssueOut { get; set; }
        public decimal QCReceiving { get; set; }
        public decimal TotalPrice { get; set; }



    }
}