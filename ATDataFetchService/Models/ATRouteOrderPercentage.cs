using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATDataFetchService.Models
{
    public class ATRouteOrderPercentage
    {
        [Key]
        public string Route { get; set; }

        public decimal OrderPercentage { get; set; }
    }
}
