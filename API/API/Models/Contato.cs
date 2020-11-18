using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tbCtt")]
    public class Contato
    {
        [Key]
        public int cttCod { get; set; }
        public string cttDsc { get; set; }

        public TipoContato TipoContato { get; }
        public int cttTipCod { get; set; }

        public Pessoa Pessoa { get; }
        public int pesCod { get; set; }



    }
}
