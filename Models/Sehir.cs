using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyTurkey.Models
{
    public class Sehir
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int BolgeId { get; set; }
        [Required, MaxLength(50)]
        public string SehirAd { get; set; }
        public  int Nufus { get;  set; }

        public Bolge Bolge { get; set; }

        
    }
}
