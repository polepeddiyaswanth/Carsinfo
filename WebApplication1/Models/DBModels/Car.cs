using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models.DBModels
{
    public partial class Car
    {
        public int CarModelNo { get; set; }
        public string CarCompany { get; set; }
        public string CarName { get; set; }
        public string CarColor { get; set; }
        public string CarTransmission { get; set; }
        public string CarFuelType { get; set; }
        public string CarBodyType { get; set; }
        public string EngineCc { get; set; }
        public string BootSpace { get; set; }
    }
}
