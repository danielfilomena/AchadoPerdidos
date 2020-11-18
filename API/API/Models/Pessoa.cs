using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tbPes")]
    public class Pessoa
    {
        [Key]
        public int pesCod { get; set; }
        public string pesNome { get; set; }
        public string pesUltNome { get; set; }
        public string pesCPF { get; set; }
        public string pesSenha { get; set; }
        public DateTime? pesDtaCad { get; set; }
        public DateTime? pesDtaAlt { get; set; }
        public bool pesInativo { get; set; }
        public bool pesExcluido { get; set; }
        public List<Contato> Contato { get; set; }

    }
}
