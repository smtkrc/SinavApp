using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SinavProje.Models
{
    public class Sorular
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string SoruAd { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
