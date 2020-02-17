using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroProject.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Heroname { get; set; }
        public string Herorealname { get; set; }
        public string Heroprimarypower { get; set; }
        public string Herosecondarypower { get; set; }
        public string catchphrase { get; set; }
    }
}
