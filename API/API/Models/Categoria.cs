using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tbCat")]
    public class Categoria
    {

        [Key]
        public int catCod { get; set; }
        public string catDsc { get; set; }
        public DateTime? catDtaCad { get; set; }
        public DateTime? catDtaAlt { get; set; }
        public bool catInativo { get; set; }
        public bool catExcluido { get; set; }

    }
}
