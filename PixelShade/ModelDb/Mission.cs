using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelShade.ModelDb
{
    internal class Mission
    {
        [Key]
        public long IdMission { get; set; }
        public DateOnly EventDate { get; set; }
        public string Description { get; set; }
        public string? FinishMission { get; set; }
    }
}
