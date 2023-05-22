using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameECG.Library.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("Sickness")]
        public int SicknessId { get; set; }
        public Sickness Sickness { get; set; }
    }
}
