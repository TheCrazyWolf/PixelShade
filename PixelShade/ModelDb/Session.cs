using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelShade.ModelDb
{
    internal class Session
    {
        [Key]
        public long IdSession { get; set; }
        public string Host { get; set; }
        public User User { get; set; }
        public DateTime StartSession { get; set; }
        public DateTime EndSession { get; set; }
        public List<Logs> Logs { get; set; }
    }
}
