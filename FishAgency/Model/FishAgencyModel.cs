using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAgency.Model
{
    class FishAgencyModel
    {
        public int ShipLenght { get; set; }
        public string Ship { get; set; }
        public string Fuel { get; set; }
        public int EnginePower { get; set; }
        public string Marking  { get; set; }
        public int InternationalNumber  { get; set; }
        public string Captan { get; set; }
        public string FishingLicense { get; set; }
        public int DateOfExpire { get; set; }
        public string FishingEquipments { get; set; }
    }
}
