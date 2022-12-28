using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelShade.ModelDb
{
    internal class User
    {
        [Key]
        public long idUser { get; set; }
        public string Login { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }

        public bool Active { get; set; }
    }
}
