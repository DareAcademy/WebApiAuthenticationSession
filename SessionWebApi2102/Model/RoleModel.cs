using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SessionWebApi2102.Model
{
    public class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
}
