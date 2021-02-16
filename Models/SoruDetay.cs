using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinavProje.Models
{
    public class SorularDetay
    {
        [Key]
        public int ID { get; set; }
        public string SoruBaslik { get; set; }
        public string SoruMetin { get; set; }
        public string Soru1 { get; set; }
        public string Soru2 { get; set; }
        public string Soru3 { get; set; }
        public string Soru4 { get; set; }
        public string S1A { get; set; }
        public string S1B { get; set; }
        public string S1C { get; set; }
        public string S1D { get; set; }
        public string S2A { get; set; }
        public string S2B { get; set; }
        public string S2C { get; set; }
        public string S2D { get; set; }
        public string S3A { get; set; }
        public string S3B { get; set; }
        public string S3C { get; set; }
        public string S3D { get; set; }
        public string S4A { get; set; }
        public string S4B { get; set; }
        public string S4C { get; set; }
        public string S4D { get; set; }
        public string SC1 { get; set; }
        public string SC2 { get; set; }
        public string SC3 { get; set; }
        public string SC4 { get; set; }
        public string Tarih { get; set; }
        public byte Durum { get; set; }
    }
}
