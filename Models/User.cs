﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SinavProje.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Password { get; set; }
    }
}
