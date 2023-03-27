using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATDataFetchService.Models
{
    public class ATOrderDetailsOutput
    {
        public string monthValue { get; set; }
        [Key]
        public string monthId { get; set; }

        public string countOfATOrders { get; set; }
      
        public string client { get; set; }
    }
}
