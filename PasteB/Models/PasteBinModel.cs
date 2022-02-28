using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PasteB.Models
{
    public class PasteBinModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tytul { get; set; }
        [Required]
        public string Tekst { get; set; }
        public string Autor { get; set; }
        public bool Logged { get; set; }
        public string Time { get; set; }

    }
}
