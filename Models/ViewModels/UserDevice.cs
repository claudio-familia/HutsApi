using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HutsApi.Models.ViewModels
{
    public class UserDevice
    {
        [Required]
        public string IMEI { get; set; }
    }
}
