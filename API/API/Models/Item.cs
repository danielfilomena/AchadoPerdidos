using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tbIte")]
    public class Item
    {

        [Key]
        public int iteCod { get; set; }
        public string iteDsc { get; set; }
        public string iteLoc { get; set; }
        public DateTime iteDtaCad { get; set; }
        public DateTime? iteDtaAlt { get; set; }
        public DateTime? iteDtaEnt { get; set; }
        public bool iteEntregue { get; set; }
        public bool iteInativo { get; set; }
        public bool iteExcluido { get; set; }

        public Categoria Categoria { get; }
        public int catCod { get; set; }

        public Pessoa Pessoa { get; }
        public int pesCod { get; set; }




    }
}
