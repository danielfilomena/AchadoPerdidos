using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tbItePic")]
    public class ItemFoto
    {

        [Key]
        public int itePicCod { get; set; }
        public string itePicPath { get; set; }

        public Item Item { get; }
        public int itemCod { get; set; }

    }
}
