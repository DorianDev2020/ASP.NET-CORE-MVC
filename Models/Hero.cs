using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace heroproject1.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string HeroNumber { get; set; }
        public string HeroName { get; set; }
        public string HeroPower { get; set; }
    }
}
