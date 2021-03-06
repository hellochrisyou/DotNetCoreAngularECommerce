using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CYouEcommerce.Core.EFTables;
using CYouEcommerce.Core.EFTables.Hardware;
using CYouEcommerce.Persistence;
namespace CyouEcommerce.Controllers.Resources
{
    public class OrderResource
    {
        public int Id { get; set; }        
        public int Order_Number { get; set; } 
        public Account AccountInfoOrder { get; set; }
        public int AccountInfoOrderId { get; set; }    
        public string Address  { get; set;}   
        public string State { get; set; }
        public string ZipCode { get; set; }       
        public DateTime OrderDate { get; set; } 
        public string Type { get; set; }
        public string CPU { get; set; } 
        public string Motherboard { get; set; }
        public string RAM { get; set; } 
        public string Storage { get; set; }
        public string GPU { get; set; } 
        public string Power_Supply { get; set; }
        public string Cooling_Fan { get; set; } 
        public string Case { get; set; }
        public float Total_Price { get; set; }                
    }
}