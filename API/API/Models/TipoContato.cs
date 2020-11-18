using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tbCttTip")]
    public class TipoContato
    {
        [Key]
        public int cttTipCod { get; set; }
        public string cttTipDsc { get; set; }

    }
}
