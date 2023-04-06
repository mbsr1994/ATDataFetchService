using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATDataFetchService.Models
{
    public class ATCustomerOrderPercentage
    {
        [Key]
        public string Customer  { get; set; }

        public decimal OrderPercentage { get; set; }
    }
}
