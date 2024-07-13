using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public GenderEnum Gender { get; set; }
    }
}
