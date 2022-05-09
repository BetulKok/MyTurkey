using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyTurkey.Models
{
    public class Bolge
    {
        //otomatik artan olmasını istemediğimiz durumlarda. defoult hali .identity
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required , MaxLength(50)]
        public string BolgeAd { get; set; }

        public List<Sehir> Sehirler { get; set; }

    }
}
